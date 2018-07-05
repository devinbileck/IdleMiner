using System.Diagnostics;
using System.Threading;

namespace IdleMiner
{
    class SystemActivity
    {
        public static int GetCPUUsage(string instanceName = "_Total")
        {
            PerformanceCounter cpuCounter = new PerformanceCounter
            {
                CategoryName = "Processor",
                CounterName = "% Processor Time",
                InstanceName = instanceName
            };
            try
            {
                // Initial value will always be 0
                float initialValue = cpuCounter.NextValue();
                // Wait before getting the value again
                Thread.Sleep(1000);
                // Second time getting the value will be correct
                return (int)cpuCounter.NextValue();
            }
            catch (System.InvalidOperationException)
            {
                return 0;
            }
        }
    }
}
