using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ShellOverlay.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _statusTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialization logic
            this.Width = SystemParameters.PrimaryScreenWidth;
            this.Left = 0;
            this.Top = 0;

            // Set up the timer
            _statusTimer.Interval = TimeSpan.FromSeconds(1); // update every second
            _statusTimer.Tick += StatusTimer_Tick;
            _statusTimer.Start();
        }

        private void StatusTimer_Tick(object? sender, EventArgs e)
        {
            // Example: update status text dynamically
            StatusTextBlock.Text = $"🧠 CPU: {GetCpuUsage()}%  💾 Disk: {GetDiskUsage()}%  🌐 Net: {GetNetworkStatus()}";
        }

        // Event handler for when the window size changes
        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double height = e.NewSize.Height;
            double width = e.NewSize.Width;

            // Example: scale font size proportionally
            double baseFontSize = 14;
            double scaledFontSize = baseFontSize * (height / 250); // 250 is your default height

            // Apply to controls (if named)
            StatusTextBlock.FontSize = scaledFontSize;
            WorkspaceLabel.FontSize = scaledFontSize;

            // Optional: adjust icon sizes, padding, or layout spacing
        }

        // Event handler for updating status information
        // Stub methods for now — wire these up later
        private int GetCpuUsage() => 12;
        private int GetDiskUsage() => 40;
        private string GetNetworkStatus() => "OK";
    }
}