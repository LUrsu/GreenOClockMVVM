using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;

namespace GreenOClock.ViewModel
{
    class NavBarViewModel
    {
        public RelayCommand HomeCommand { get; set; }
        public RelayCommand ActiveCommand { get; set; }
        public RelayCommand ManageCommand { get; set; }
        public RelayCommand ManageTagsCommand { get; set; }

        public NavBarViewModel()
        {
            HomeCommand = new RelayCommand(NavigateHome);
            ActiveCommand = new RelayCommand(NavigateActive);
            ManageCommand = new RelayCommand(NavigateManage);
            ManageTagsCommand = new RelayCommand(NavigateManageTags);
        }

        public void NavigateHome()
        {
            if(SessionData.CurrentUser != null)
                Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.HomePage });
            else
                NavigateToLogin();
        }

        public void NavigateToLogin()
        {
            Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.Login });
        }

        public void NavigateActive()
        {
            //if(SessionData.CurrentUser != null)
                Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.CurrentActivity });
            //else
                //NavigateToLogin();
        }

        public void NavigateManage()
        {
            //if(SessionData.CurrentUser != null)
                Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.AddActivities });
            //else 
                //NavigateToLogin();
        }

        public void NavigateManageTags()
        {
            //if(SessionData.CurrentUser != null)
                Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.ManageTags });
            //else 
                //NavigateToLogin();
        }
    }
}
