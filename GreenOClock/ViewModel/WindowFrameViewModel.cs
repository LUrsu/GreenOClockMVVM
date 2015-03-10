using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Views;

namespace GreenOClock.ViewModel
{
    public class WindowFrameViewModel : ViewModelBase
    {
        public Dictionary<WindowViews, UserControl> UserControls;

        public UserControl ActiveFrameDisplay { get; set; }

        private WindowViews _activeWindowEnum;
        public WindowViews ActiveControlEnum
        {
            get { return _activeWindowEnum; }

            set
            {
                _activeWindowEnum = value;
                Messenger.Default.Send(new SwitchViewMessage() {ShowControl = _activeWindowEnum} );
                RaisePropertyChanged("ActiveControlEnum");
            }
        }   

        public WindowFrameViewModel()
        {
            //nty //Closing += (s, e) => ViewModelLocator.Cleanup();

            RegisterEntities();

            Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.Welcome});
        }

        public void RegisterEntities()
        {
            Messenger.Default.Register<SwitchViewMessage>(this, UpdateView);


            UserControls = new Dictionary<WindowViews, UserControl>
                {
                    {WindowViews.HomePage, new HomePageView()},
                    {WindowViews.CurrentActivity, new CurrentActivityView()},
                    {WindowViews.AddActivities, new AddActivitiesView()},
                    {WindowViews.CreateActivities, new CreateActivitiesView()},
                    {WindowViews.ManageTags, new ManageTagsView()},
                    {WindowViews.Welcome, new WelcomeView()},
                    {WindowViews.Login, new LoginView()},
                    {WindowViews.RegisterUser, new RegisterUserView()}
                };
        }

        public RelayCommand SubmitButtonCommand { get; set; }

        public void UpdateView(SwitchViewMessage message)
        {
            ActiveFrameDisplay = UserControls[message.ShowControl];
            RaisePropertyChanged("ActiveFrameDisplay");;
        }
    }
}
