using System.Windows.Controls;

namespace GreenOClock.Views
{
    /// <summary>
    /// Interaction logic for CurrentActivityView.xaml
    /// </summary>
    public partial class CurrentActivityView : UserControl
    {
        public string Header { get; set; }

        public CurrentActivityView()
        {
            InitializeComponent();

            Header = "Active Activity";
        }
    }
}
