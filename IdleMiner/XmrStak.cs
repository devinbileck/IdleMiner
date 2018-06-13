using System.Diagnostics;
using System.IO;

namespace IdleMiner
{
    class XmrStak
    {
        private Process process;
        public string Path { get; set; }

        public XmrStak(string path)
        {
            Path = path;
        }

        public bool IsRunning()
        {
            if (!File.Exists(Path))
                return false;
            string fileName = System.IO.Path.GetFileName(Path);
            Process[] processes = Process.GetProcessesByName(fileName.Substring(0, fileName.LastIndexOf('.')));
            return processes.Length > 0;
        }

        public void StartIdleMode(Settings settings)
        {
            string cpuFile = "";
            string nvidiaFile = "";
            string amdFile = "";
            if (settings.IdleCpuEnabled)
                cpuFile = settings.IdleCpuFile;
            if (settings.IdleNvidiaEnabled)
                nvidiaFile = settings.IdleNvidiaFile;
            if (settings.IdleAmdEnabled)
                amdFile = settings.IdleAmdFile;
            Start(settings.ConfigFile, settings.PoolFile, cpuFile, nvidiaFile, amdFile);
        }

        public void StartActiveMode(Settings settings)
        {
            string cpuFile = "";
            string nvidiaFile = "";
            string amdFile = "";
            if (settings.ActiveCpuEnabled)
                cpuFile = settings.ActiveCpuFile;
            if (settings.ActiveNvidiaEnabled)
                nvidiaFile = settings.ActiveNvidiaFile;
            if (settings.ActiveAmdEnabled)
                amdFile = settings.ActiveAmdFile;
            Start(settings.ConfigFile, settings.PoolFile, cpuFile, nvidiaFile, amdFile);
        }

        public void Start(string configFile, string poolFile, string cpuFile = "", string nvidiaFile = "", string amdFile = "")
        {
            if (IsRunning())
            {
                try
                {
                    Stop();
                }
                catch (System.Exception)
                {
                    return;
                }
            }
            process = new Process();
            bool validConfig = false;
            process.StartInfo.FileName = Path;
            string[] arguments = new string[5];
            arguments[0] = string.Format("--config \"{0}\"", configFile);
            arguments[1] = string.Format("--poolconf \"{0}\"", poolFile);
            arguments[2] = "--noCPU";
            arguments[3] = "--noNVIDIA";
            arguments[4] = "--noAMD";
            if (File.Exists(cpuFile))
            {
                arguments[2] = string.Format("--cpu \"{0}\"", cpuFile);
                validConfig = true;
            }
            if (File.Exists(nvidiaFile))
            {
                arguments[3] = string.Format("--nvidia \"{0}\"", nvidiaFile);
                validConfig = true;
            }
            if (File.Exists(amdFile))
            {
                arguments[4] = string.Format("--amd \"{0}\"", amdFile);
                validConfig = true;
            }
            if (validConfig == false)
            {
                return;
            }
            process.StartInfo.Arguments = string.Join(" ", arguments);
            process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            process.Start();
        }

        public void Stop()
        {
            if (!IsRunning())
            {
                return;
            }
            try
            {
                process.Kill();
            }
            catch (System.Exception)
            {
                string fileName = System.IO.Path.GetFileName(Path);
                Process[] processes = Process.GetProcessesByName(
                    fileName.Substring(0, fileName.LastIndexOf('.')));
                if (processes.Length > 0)
                    processes[0].Kill();
            }
        }
    }
}
