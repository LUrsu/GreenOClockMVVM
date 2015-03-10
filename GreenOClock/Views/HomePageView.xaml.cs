using System;
using System.Collections.Generic;
using System.Linq;
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
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;
using GreenOClock.ViewModel;

namespace GreenOClock.Views
{
    /// <summary>
    /// Interaction logic for HomePageView.xaml
    /// </summary>
    public partial class HomePageView : UserControl
    {
        public string Header { get; set; }

        public HomePageView()
        {
            InitializeComponent();

            Header = "Welcome to Green O'Clock";
        }



        //public void SetUpUserData(IUser CurrentUser)
        //{
        //    //needs the server to finish
        //    //SessionData.CurrentUser = CurrentUser;
        //    //SessionData.CurrentUser.AllUsersActivity.Add()
        //}
    }
}
