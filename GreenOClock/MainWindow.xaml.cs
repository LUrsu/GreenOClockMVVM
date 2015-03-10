using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;
using GreenOClock.ViewModel;
using GreenOClock.Views;

namespace GreenOClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dictionary<WindowViews, UserControl> UserControls;
 

        public MainWindow()
        {
            InitializeComponent();
            var data = DataLayer.Instance;
            Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.Welcome});
        }
    }
}
