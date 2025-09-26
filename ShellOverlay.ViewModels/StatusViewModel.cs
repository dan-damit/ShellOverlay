using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using ShellOverlay.Core;

namespace ShellOverlay.ViewModels
{
    public class StatusViewModel : INotifyPropertyChanged
    {
        private readonly MetricsService _metrics;
        private readonly System.Timers.Timer _timer;

        private string _statusLine = "🧠 CPU: --%  💾 Disk: --%  🌐 Net: --";
        public string StatusLine
        {
            get => _statusLine;
            set { _statusLine = value; OnPropertyChanged(); }
        }

        public StatusViewModel(MetricsService metrics)
        {
            _metrics = metrics;

            _timer = new System.Timers.Timer(1000); // 1 second
            _timer.Elapsed += (s, e) => UpdateStatus();
            _timer.AutoReset = true;
            _timer.Start();
        }

        private void UpdateStatus()
        {
            var cpu = _metrics.GetCpuUsage();
            var disk = _metrics.GetDiskUsage();
            var net = _metrics.GetNetworkStatus();

            StatusLine = $"🧠 CPU: {cpu}%  💾 Disk: {disk}%  🌐 Net: {net}";
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}