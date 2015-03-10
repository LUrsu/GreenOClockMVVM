using System.Windows.Controls;

namespace GreenOClock.Views
{
    /// <summary>
    /// Interaction logic for CreateActivitiesView.xaml
    /// </summary>
    public partial class CreateActivitiesView : UserControl
    {
        public string Header { get; set; }

        public CreateActivitiesView()
        {
            InitializeComponent();
            Header = "Create Activities";
        }
    }
}
