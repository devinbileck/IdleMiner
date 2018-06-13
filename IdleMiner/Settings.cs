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
        }

        public static Settings FromDefaults(string settingsFilePath)
        {
            Settings settings = new Settings(settingsFilePath);
            settings.IdleTime = 60;
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "xmr-stak.exe")))
            {
                settings.MinerLocation = Path.Combine(Environment.CurrentDirectory, "xmr-stak.exe");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "config.txt")))
            {
                settings.ConfigFile = Path.Combine(Environment.CurrentDirectory, "config.txt");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "pools.txt")))
            {
                settings.PoolFile = Path.Combine(Environment.CurrentDirectory, "pools.txt");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "cpu.txt")))
            {
                settings.IdleCpuEnabled = true;
                settings.ActiveCpuFile = Path.Combine(Environment.CurrentDirectory, "cpu.txt");
                settings.IdleCpuFile = Path.Combine(Environment.CurrentDirectory, "cpu.txt");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "amd.txt")))
            {
                settings.IdleAmdEnabled = true;
                settings.ActiveAmdFile = Path.Combine(Environment.CurrentDirectory, "amd.txt");
                settings.IdleAmdFile = Path.Combine(Environment.CurrentDirectory, "amd.txt");
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "nvidia.txt")))
            {
                settings.IdleNvidiaEnabled = true;
                settings.ActiveNvidiaFile = Path.Combine(Environment.CurrentDirectory, "nvidia.txt");
                settings.IdleNvidiaFile = Path.Combine(Environment.CurrentDirectory, "nvidia.txt");
            }
            settings.ToJsonFile();
            return settings;
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
