using System;
using System.Diagnostics;

namespace ShellOverlay.Core
{
    public class MetricsService
    {
        private readonly PerformanceCounter _cpuCounter;
        private readonly PerformanceCounter _diskCounter;

        public MetricsService()
        {
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            _diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");

            // Prime counters (first read is often 0)
            _cpuCounter.NextValue();
            _diskCounter.NextValue();
        }

        public int GetCpuUsage()
        {
            return (int)Math.Round(_cpuCounter.NextValue());
        }

        public int GetDiskUsage()
        {
            return (int)Math.Round(_diskCounter.NextValue());
        }

        public string GetNetworkStatus()
        {
            // Placeholder: you can expand this later with real interface stats
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() ? "Online" : "Offline";
        }
    }
}