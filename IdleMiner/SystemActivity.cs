using System;
using System.Diagnostics;
using System.Threading;

namespace IdleMiner
{
    class SystemActivity
    {
        public static (int total, int process) GetCPUUsage(Process process = null)
        {
            PerformanceCounter totalCpuCounter = null;
            PerformanceCounter processCpuCounter = null;

            totalCpuCounter = new PerformanceCounter
            {
                CategoryName = "Processor",
                CounterName = "% Processor Time",
                InstanceName = "_Total"
            };
            totalCpuCounter.NextValue();    // Initialize to start capturing (initial value will always be 0)

            if (process != null)
            {
                processCpuCounter = new PerformanceCounter
                {
                    CategoryName = "Process",
                    CounterName = "% Processor Time",
                    InstanceName = process.ProcessName
                };
                processCpuCounter.NextValue();  // Initialize to start capturing (initial value will always be 0)
            }

            // Allow some time to accumulate data
            Thread.Sleep(1000);

            if (process == null)
            {
                return ((int)totalCpuCounter.NextValue(), 0);
            }
            else
            {
                // CPU data for a specific process is provided as a percentage of a single core
                // so have to divide by ProcessorCount to get an overall value
                return ((int)totalCpuCounter.NextValue(), (int)(processCpuCounter.NextValue() / Environment.ProcessorCount));
            }
        }
    }
}
