using ShellOverlay.Core;

namespace ShellOverlay.ViewModels
{
    public class StatusViewModel
    {

        private readonly MetricsService _metrics = new MetricsService();

        private void UpdateStatus()
        {
            var cpu = _metrics.GetCpuUsage();
            var disk = _metrics.GetDiskUsage();
            var net = _metrics.GetNetworkStatus();

            StatusLine = $"🧠 CPU: {cpu}%  💾 Disk: {disk}%  🌐 Net: {net}";
        }
    }
}
