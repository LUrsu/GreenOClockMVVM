using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;

namespace GreenOClock.ViewModel
{
    public class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel()
        {
            Messenger.Default.Register<LoadUserMessage>(this, Initialize);

            //    SessionData.UsersActivities.OrderByDescending(p=>p.UserParticipatingActivities.Select(y=>y.InitialStart)).Take(10).ToList();
            //foreach (var upcomingActivity in upcomingActivities)
            //{
            //    UpcomingActivities.Add(upcomingActivity);
            //}
            //TODO initialize UpcomingActivities to the next 5 activities
            //UpcomingActivities = from all activities, where userId matches userId
            //select top 5 ordered by start date ascending
        }

        public void Initialize(LoadUserMessage message)
        {
            UpcomingActivities = SessionData.CurrentUser.Activities;
        }

        private EntityCollection<Activity> _upcomingActivities;
        public EntityCollection<Activity> UpcomingActivities
        {
            get { return _upcomingActivities; }
            set
            {
                _upcomingActivities = value;
                RaisePropertyChanged("UpcomingActivities");
            }
        }

        private Activity _selectedActivity;
        public Activity SelectedActivity
        {
            get { return _selectedActivity; }
            set
            {
                _selectedActivity = value;
                RaisePropertyChanged("SelectedActivity");
            }
        }
    }
}
