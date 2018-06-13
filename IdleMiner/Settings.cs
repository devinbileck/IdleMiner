using Newtonsoft.Json;
using System;
using System.IO;

namespace IdleMiner
{
    public class Settings
    {
        private string filePath;
        public string MinerLocation { get; set; }
        public string ConfigFile { get; set; }
        public string PoolFile { get; set; }
        public decimal IdleTime { get; set; }
        public bool ActiveAmdEnabled { get; set; }
        public string ActiveAmdFile { get; set; }
        public bool ActiveCpuEnabled { get; set; }
        public string ActiveCpuFile { get; set; }
        public bool ActiveNvidiaEnabled { get; set; }
        public string ActiveNvidiaFile { get; set; }
        public bool IdleAmdEnabled { get; set; }
        public string IdleAmdFile { get; set; }
        public bool IdleCpuEnabled { get; set; }
        public string IdleCpuFile { get; set; }
        public bool IdleNvidiaEnabled { get; set; }
        public string IdleNvidiaFile { get; set; }

        public Settings(string settingsFilePath)
        {
            filePath = settingsFilePath;
            IdleTime = 60;

            // Attempt to automatically set files if located in same directory
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "config.txt")))
            {
                ConfigFile = Path.Combine(Environment.CurrentDirectory, "config.txt");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "pools.txt")))
            {
                PoolFile = Path.Combine(Environment.CurrentDirectory, "pools.txt");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "cpu.txt")))
            {
                IdleCpuEnabled = true;
                ActiveCpuFile = Path.Combine(Environment.CurrentDirectory, "cpu.txt");
                IdleCpuFile = Path.Combine(Environment.CurrentDirectory, "cpu.txt");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "amd.txt")))
            {
                IdleAmdEnabled = true;
                ActiveAmdFile = Path.Combine(Environment.CurrentDirectory, "amd.txt");
                IdleAmdFile = Path.Combine(Environment.CurrentDirectory, "amd.txt");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "nvidia.txt")))
            {
                IdleNvidiaEnabled = true;
                ActiveNvidiaFile = Path.Combine(Environment.CurrentDirectory, "nvidia.txt");
                IdleNvidiaFile = Path.Combine(Environment.CurrentDirectory, "nvidia.txt");
            }
        }

        public static Settings FromJsonFile(string settingsFilePath)
        {
            if (!File.Exists(settingsFilePath))
            {
                throw new IOException("Specified settings file does not exist: " + settingsFilePath);
            }
            Settings settings = new Settings(settingsFilePath);
            using (StreamReader r = new StreamReader(settingsFilePath))
            {
                settings = JsonConvert.DeserializeObject<Settings>(r.ReadToEnd());
                settings.filePath = settingsFilePath;
            }
            return settings;
        }

        public void ToJsonFile()
        {
            string jsonData = JsonConvert.SerializeObject(this);
            using (StreamWriter file = new StreamWriter(filePath))
            {
                file.WriteLine(jsonData);
            }
        }
    }
}
