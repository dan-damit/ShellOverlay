using System.Runtime.Versioning;
using System.Windows;
using ShellOverlay.Core;
using ShellOverlay.ViewModels;

namespace ShellOverlay.UI
{
    [SupportedOSPlatform("windows")]
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Inject MetricsService into the ViewModel
            DataContext = new StatusViewModel(new MetricsService());
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Width = SystemParameters.PrimaryScreenWidth;
            this.Left = 0;
            this.Top = 0;
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double height = e.NewSize.Height;
            double baseFontSize = 14;
            double scaledFontSize = baseFontSize * (height / 250);

            // You can still scale via binding or directly adjust styles
            // If you want to keep it MVVM‑pure, expose a FontSize property in the VM
        }
    }
}