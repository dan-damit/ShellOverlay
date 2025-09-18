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

namespace ShellOverlay.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for when the window is loaded
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialization logic here
            this.Width = SystemParameters.PrimaryScreenWidth;
            this.Left = 0;
            this.Top = 0;

            // Optional: Hide taskbar or initialize modules
            // TaskbarManager.HideTaskbar();
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
    }
}