using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Objects.DataClasses;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;

namespace GreenOClock.ViewModel
{
    public class CurrentActivityViewModel : ViewModelBase
    {
        public RelayCommand StartTimerCommand { get; set; }
        public RelayCommand StopTimerCommand { get; set; }
        public RelayCommand PauseTimerCommand { get; set; }
        public string TotalTime { get; set; }

        public TimerModel Watch;

        public CurrentActivityViewModel()
        {
            Messenger.Default.Register<LoadUserMessage>(this, Initialize);
            StopTimerCommand = new RelayCommand(StopTimer);
            StartTimerCommand = new RelayCommand(StartTimer);
            PauseTimerCommand = new RelayCommand(PauseTimer);

            Watch = new TimerModel();
        }


        private void Initialize(LoadUserMessage message)
        {
            //UsersActivityTags = SessionData.CurrentUser;

            Messenger.Default.Register<ChangeActiveActivityMessage>(this, UpdateActiveActivity);
        }

        public void UpdateActiveActivity(ChangeActiveActivityMessage message)
        {
            ActiveActivity = message.ActiveActivity;
        }

        private void PauseTimer()
        {
            Watch.Tock();
            Watch.OnTimeChange -= UpdateActivityTime;
        }

        private void StopTimer()
        {
            Watch.Tock();
            Watch.OnTimeChange -= UpdateActivityTime;
        }

        public void StartTimer()
        {
            Watch.Tick();
            Watch.OnTimeChange += UpdateActivityTime;
        }

        public void UpdateActivityTime( object sender, EventArgs e )
        {
            TotalTime = Watch.CurrentTime.TotalSeconds.ToString();
            RaisePropertyChanged("TotalTime");
        }

        private EntityCollection<Tag> _usersActivityTags;
        public EntityCollection<Tag> UsersActivityTags
        {
            get { return _usersActivityTags; }
            set
            {
                _usersActivityTags = value;
                RaisePropertyChanged("UsersActivityTags");
            }
        }

        private Tag _selectedTag;
        public Tag SelectedTag
        {
            get { return _selectedTag; }
            set
            {
                _selectedTag = value;
                RaisePropertyChanged("SelectedTags");
            }
        }

        private Activity _activeActivity;
        public Activity ActiveActivity
        {
            get { return _activeActivity; }
            set
            {
                _activeActivity = value;
                ActiveActivityName = value.Name;
                RaisePropertyChanged("ActiveActivity");
            }
        }

        private string _activeActivityName;
        public string ActiveActivityName
        {
            get { return _activeActivityName; }
            set
            {
                _activeActivityName = ActiveActivity.Name;
                RaisePropertyChanged("ActiveActivityName");
            }
        }



        public EventHandler UpdateActiveTime { get; set; }
    }
}
