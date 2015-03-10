using System.Windows.Controls;

namespace GreenOClock.Views
{
    /// <summary>
    /// Interaction logic for ManageTagsView.xaml
    /// </summary>
    public partial class ManageTagsView : UserControl
    {
        public string Header { get; set; }

        public ManageTagsView()
        {
            InitializeComponent();
            Header = "Manage Tags";
        }
    }
}
