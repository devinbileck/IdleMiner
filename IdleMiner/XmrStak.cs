using System.Diagnostics;
using System.IO;

namespace IdleMiner
{
    class XmrStak : Miner
    {
        public string Path { get; set; }

        public XmrStak(string path, string arguments = null) : base(path, arguments)
        {
            Path = path;
        }

        public void StartIdleMode(Settings settings)
        {
            bool validConfig = false;
            string[] arguments = new string[5];
            arguments[0] = string.Format("--config \"{0}\"", settings.ConfigFile);
            arguments[1] = string.Format("--poolconf \"{0}\"", settings.PoolFile);
            arguments[2] = "--noCPU";
            arguments[3] = "--noNVIDIA";
            arguments[4] = "--noAMD";
            if (settings.IdleCpuEnabled && File.Exists(settings.IdleCpuFile))
            {
                arguments[2] = string.Format("--cpu \"{0}\"", settings.IdleCpuFile);
                validConfig = true;
            }
            if (settings.IdleNvidiaEnabled && File.Exists(settings.IdleNvidiaFile))
            {
                arguments[3] = string.Format("--nvidia \"{0}\"", settings.IdleNvidiaFile);
                validConfig = true;
            }
            if (settings.IdleAmdEnabled && File.Exists(settings.IdleAmdFile))
            {
                arguments[4] = string.Format("--amd \"{0}\"", settings.IdleAmdFile);
                validConfig = true;
            }
            if (validConfig == false)
            {
                return;
            }
            Stop();
            Arguments = string.Join(" ", arguments);
            Start();
        }

        public void StartActiveMode(Settings settings)
        {
            bool validConfig = false;
            string[] arguments = new string[5];
            arguments[0] = string.Format("--config \"{0}\"", settings.ConfigFile);
            arguments[1] = string.Format("--poolconf \"{0}\"", settings.PoolFile);
            arguments[2] = "--noCPU";
            arguments[3] = "--noNVIDIA";
            arguments[4] = "--noAMD";
            if (settings.ActiveCpuEnabled && File.Exists(settings.ActiveCpuFile))
            {
                arguments[2] = string.Format("--cpu \"{0}\"", settings.ActiveCpuFile);
                validConfig = true;
            }
            if (settings.ActiveNvidiaEnabled && File.Exists(settings.ActiveNvidiaFile))
            {
                arguments[3] = string.Format("--nvidia \"{0}\"", settings.ActiveNvidiaFile);
                validConfig = true;
            }
            if (settings.ActiveAmdEnabled && File.Exists(settings.ActiveAmdFile))
            {
                arguments[4] = string.Format("--amd \"{0}\"", settings.ActiveAmdFile);
                validConfig = true;
            }
            if (validConfig == false)
            {
                return;
            }
            Stop();
            Arguments = string.Join(" ", arguments);
            Start();
        }
    }
}
