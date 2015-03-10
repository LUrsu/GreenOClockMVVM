using System.Collections.ObjectModel;
using System.Data.Objects.DataClasses;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;

namespace GreenOClock.ViewModel
{
    public class CreateActivityViewModel : ViewModelBase
    {
        public RelayCommand CreateActivityCommand { get; set; }
        public RelayCommand RemoveSelectedTagFromListBox { get; set; }
        public RelayCommand AddSelectedTags { get; set; }

        private ObservableCollection<Tag> _unUsedActivitiesTags;
        public ObservableCollection<Tag> UnUsedActivitiesTags
        {
            get { return _unUsedActivitiesTags; }
            set
            {
                _unUsedActivitiesTags = value;
                RaisePropertyChanged("UnUsedActivitiesTags");
            }
        }
        private ObservableCollection<Tag> _usedActivitiesTags;
        public ObservableCollection<Tag> UsedActivitiesTags
        {
            get { return _usedActivitiesTags; }
            set 
            { 
                _usedActivitiesTags = value;
                RaisePropertyChanged("UsedActivitiesTags");
            }
        }

        private Tag _unUsedSellectedActivitiesTags;
        public Tag UnUsedSellectedActivitiesTags
        {
            get { return _unUsedSellectedActivitiesTags; }
            set
            {
                _unUsedSellectedActivitiesTags = value;
                RaisePropertyChanged("UnUsedSellectedActivitiesTags");
            }
        }
        private Tag _usedSellectedActivitiesTags;
        public Tag UsedSellectedActivitiesTags
        {
            get { return _usedSellectedActivitiesTags; }
            set
            {
                _usedSellectedActivitiesTags = value;
                RaisePropertyChanged("UsedSellectedActivitiesTags");
            }
        }

        private string _newActivityName;
        public string NewActivityName
        {
            get { return _newActivityName; }
            set
            {
                _newActivityName = value;
                RaisePropertyChanged("NewActivityName");
            }
        }

        //private void ConvertToObservableCollection()
        //{
        //    var users = DataLayer.Instance.UsersRepository;
        //    if(users != null)
        //    {
        //        foreach (var tag in users.GetUsersTags(SessionData.CurrentUser))
        //        {
        //            UnUsedActivitiesTags.Add(tag);
        //        }
        //    }
            
        //}

        private EntityCollection<Tag> ConvertToEntityCollection()
        {
            var entityTags = new EntityCollection<Tag>();
            foreach (var tag in UsedActivitiesTags)
            {
                entityTags.Add(tag);
            }
            return entityTags;
        }

        public CreateActivityViewModel()
        {
            LoginViewModel.InitializePropertiesEvent += Initialize;
            //ConvertToObservableCollection();
            CreateActivityCommand = new RelayCommand(CreateActivity);
            //RemoveSelectedTagFromListBox = new RelayCommand(RemoveTagFromList);
            //AddSelectedTags = new RelayCommand(AddTagToUsedList);
        }

        private void Initialize()
        {
            //ConvertToObservableCollection();

        }

        //private void AddTagToUsedList()
        //{
        //    var tagBeingMoved = CreateActivitiesView.UnUsedTags.SelectedItem;
        //    UnUsedActivitiesTags.Remove(tagBeingMoved);
        //    UsedActivitiesTags.Add(tagBeingMoved);
        //}

        //private void RemoveTagFromList()
        //{
        //    var tagBeingMoved = CreateActivitiesView.UsedTags.SelectedItem;
        //    UsedActivitiesTags.Remove(tagBeingMoved);
        //    UnUsedActivitiesTags.Add(tagBeingMoved);

        //}

        public void CreateActivity()
        {
            if (NewActivityName != null)
            {
            var newActivity = new Activity
                {
                    Name = NewActivityName,
                    Tags = ChangeToEntityCollection(UsedActivitiesTags)
                };
            DataLayer.Instance.ActivitiesRepository.AddActivity(newActivity);
            }
            else
            {
                MessageBox.Show("You need to enter a name before you can create an activity");
            }
        }

        public EntityCollection<Tag> ChangeToEntityCollection(ObservableCollection<Tag> tags)
        {
            var newTags = new EntityCollection<Tag>();
            foreach (var tag in tags)
            {
                newTags.Add(tag);
            }
            return newTags;
        }

        public void ClickAllActivities()
        {
            Messenger.Default.Send(new SwitchViewMessage { ShowControl = WindowViews.AddActivities });
        }
    }
}
