using System.Windows.Controls;

namespace GreenOClock.Views
{
    /// <summary>
    /// Interaction logic for WelcomeView.xaml
    /// </summary>
    public partial class WelcomeView : UserControl
    {
        public string Header { get; set; }

        public WelcomeView()
        {
            InitializeComponent();
            Header = "Green O'Clock";
        }
    }
}
