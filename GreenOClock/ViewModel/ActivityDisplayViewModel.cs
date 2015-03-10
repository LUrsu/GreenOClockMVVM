using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;

namespace GreenOClock.ViewModel
{
    public class ActivityDisplayViewModel : ViewModelBase
    {
        private string _activityName;
        public string ActivityName
        {
            get { return _activityName; }
            set 
            { 
                _activityName = value;
                RaisePropertyChanged("ActivityName");
            }
        }

        private ObservableCollection<Tag> _activitiesTags;
        public  ObservableCollection<Tag> ActivitiesTags
        {
            get { return _activitiesTags; }
            set
            {
                _activitiesTags = value;
                RaisePropertyChanged("ActivitiesTags");
            }
        }

        public ActivityDisplayViewModel()
        {
            
        }
    }
}
