using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace IdleMiner
{
    public static class Program
    {
        public static Settings Settings;
        public static bool ModifiedSettings;
        public static bool MiningPaused;
        private static bool exitThreads;
        private static XmrStak xmrStak;

        [STAThread]
        public static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + AssemblyInfo.Guid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    // Instance already running
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (SystemTrayIcon systemTrayIcon = new SystemTrayIcon())
                {
                    systemTrayIcon.Display();

                    string settingsFilePath = Path.Combine(Environment.CurrentDirectory, "IdleMinerSettings.json");
                    Settings = Settings.FromDefaults(settingsFilePath);
                    if (File.Exists(settingsFilePath))
                    {
                        try
                        {
                            Settings = Settings.FromJsonFile(settingsFilePath);
                        }
                        catch (Newtonsoft.Json.JsonReaderException)
                        {
                            // Invalid json file, use default settings
                        }
                    }
                    Settings.ToJsonFile();

                    exitThreads = false;
                    MiningPaused = false;
                    ModifiedSettings = true;
                    Thread miningThread = new Thread(new ThreadStart(MiningThread));
                    miningThread.Start();

                    Application.Run();
                }

                exitThreads = true;
            }
        }

        private static void MiningThread()
        {
            bool idle = true;
            bool overCpuUsage = false;
            DateTime startActiveModeTime = DateTime.Now;
            DateTime stopActiveModeTime = DateTime.Now;

            xmrStak = new XmrStak(Settings.MinerLocation);

            for (; ; )
            {
                xmrStak.Path = Settings.MinerLocation;
                xmrStak.Command = Settings.MinerLocation;

                if (exitThreads)
                {
                    xmrStak.Stop();
                    break;
                }
                if (MiningPaused)
                {
                    if (xmrStak.FindProcess() != null)
                    {
                        Debug.WriteLine(string.Format("{0:yyyy/MM/dd HH:mm:ss tt} | Mining paused", DateTime.Now));
                        xmrStak.Stop();
                    }
                    idle = true;
                    Thread.Sleep(500);
                    continue;
                }

                int idleTime = UserActivity.GetIdleTime();
                
                if (idleTime < Settings.IdleTime)
                {
                    var cpuUsage = SystemActivity.GetCPUUsage(xmrStak.FindProcess());
                    if (cpuUsage.total - cpuUsage.process > Settings.ActiveCpuUsage)
                    {
                        if (xmrStak.IsRunning() && overCpuUsage == false && DateTime.Now.Subtract(startActiveModeTime) >= TimeSpan.FromSeconds(10))
                        {
                            Debug.WriteLine(string.Format("{0:yyyy/MM/dd HH:mm:ss tt} | Stop active mode; CPU usage > {1}% ({2}%)", DateTime.Now, Settings.ActiveCpuUsage, cpuUsage.total - cpuUsage.process));
                            xmrStak.Stop();
                            overCpuUsage = true;
                            idle = true;
                            stopActiveModeTime = DateTime.Now;
                        }
                    }
                    else
                    {
                        overCpuUsage = false;
                    }
                    if (overCpuUsage == false && (ModifiedSettings || idle || xmrStak.FindProcess() == null))
                    {
                        if (DateTime.Now.Subtract(stopActiveModeTime) >= TimeSpan.FromSeconds(10))
                        {
                            Debug.WriteLine(string.Format("{0:yyyy/MM/dd HH:mm:ss tt} | Start active mode; CPU usage <= {1}% ({2}%)", DateTime.Now, Settings.ActiveCpuUsage, cpuUsage.total - cpuUsage.process));
                            xmrStak.StartActiveMode(Settings);
                            idle = false;
                            ModifiedSettings = false;
                            startActiveModeTime = DateTime.Now;
                        }
                    }
                }
                else if (idleTime >= Settings.IdleTime && (idle == false || xmrStak.FindProcess() == null))
                {
                    Debug.WriteLine(string.Format("{0:yyyy/MM/dd HH:mm:ss tt} | Start idle mode", DateTime.Now));
                    xmrStak.StartIdleMode(Settings);
                    idle = true;
                }
                else
                {
                    Thread.Sleep(500);
                }
            }
        }

        private static void Dispose()
        {
            xmrStak.Stop();
        }
    }
}
