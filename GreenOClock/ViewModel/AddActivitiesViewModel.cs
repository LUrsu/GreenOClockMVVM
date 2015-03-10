using System.Data.Objects.DataClasses;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;

namespace GreenOClock.ViewModel
{
    public class AddActivitiesViewModel : ViewModelBase
    {
        public RelayCommand MakeActiveCommand { get; set; }
        public RelayCommand CreateActivityCommand { get; set; }
        public RelayCommand RemoveActivityCommand { get; set; }

        private EntityCollection<Activity> _allActivities;
        public EntityCollection<Activity> AllActivities
        {
            get { return _allActivities; }
            set
            {
                _allActivities = value;
                RaisePropertyChanged("AllActivities");
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

        public AddActivitiesViewModel()
        {
            MakeActiveCommand = new RelayCommand(MakeActive);
            CreateActivityCommand = new RelayCommand(ClickCreateActivity);
            RemoveActivityCommand = new RelayCommand(RemoveActivity);
            Messenger.Default.Register<LoadUserMessage>(this, Initialize);
        }

        private void Initialize(LoadUserMessage obj)
        {
            AllActivities = SessionData.CurrentUser.Activities;
        }

        public void RemoveActivity()
        {
            if(SelectedActivity != null)
            {
                AllActivities.Remove(SelectedActivity);
                DataLayer.Instance.ActivitiesRepository.RemoveActivity(SelectedActivity);
                SessionData.CurrentUser.Activities.Remove(SelectedActivity);
            }
            else
            {
                MessageBox.Show("Please select an activity");
            }
        }

        public void MakeActive()
        {
            if(SelectedActivity != null)
            {
                SessionData.ActiveActivity = SelectedActivity;
                Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.CurrentActivity});
            }
            
        }

        public void ClickCreateActivity()
        {
            Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.CreateActivities });
        }

        public void ClickMakeActive()
        {
            Messenger.Default.Send(new SwitchViewMessage() { ShowControl = WindowViews.CurrentActivity });
        }
    }
}
