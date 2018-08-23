using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace IdleMiner
{
    public static class Program
    {
        public static Settings Settings;
        public static bool ModifiedSettings;
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
                            systemTrayIcon.ShowWarningIcon();
                        }
                    }
                    Settings.ToJsonFile();

                    exitThreads = false;
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

            xmrStak = new XmrStak(Settings.MinerLocation);

            for (; ; )
            {
                if (exitThreads)
                {
                    xmrStak.Stop();
                    break;
                }

                int idleTime = UserActivity.GetIdleTime();

                if (ModifiedSettings || (idleTime < Settings.IdleTime && idle))
                {
                    xmrStak.StartActiveMode(Settings);
                    idle = false;
                    ModifiedSettings = false;
                }
                else if (idleTime >= Settings.IdleTime && idle == false)
                {
                    xmrStak.StartIdleMode(Settings);
                    idle = true;
                }
                Thread.Sleep(1000);
            }
        }

        private static void Dispose()
        {
            xmrStak.Stop();
        }
    }
}
