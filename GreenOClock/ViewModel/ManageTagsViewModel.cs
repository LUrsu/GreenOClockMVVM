using System.Collections;
using System.Collections.ObjectModel;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GreenOClock.Model;
using GreenOClock.Views;

namespace GreenOClock.ViewModel
{
    public class ManageTagsViewModel : ViewModelBase
    {
        public RelayCommand CreateTagCommand { get; set; }
        public RelayCommand RemoveTagCommand { get; set; }
        public RelayCommand UpdateSelectedTags { get; set; }

        public ManageTagsViewModel()
        {
            TagName = string.Empty;
            ActivityTags = new EntityCollection<Tag>();

            Messenger.Default.Register<LoadUserMessage>(this, Init);

            CreateTagCommand = new RelayCommand(AddNewTag);
            RemoveTagCommand = new RelayCommand(RemoveSelectedTag);
        }

        public void Init(LoadUserMessage message)
        {
            ActivityTags = SessionData.CurrentUser.Tags;
        }

        public void AddNewTag()
        {

            if (NameIsValid(TagName) && SessionData.CurrentUser != null)
            {
                var newTag = new Tag { Name = TagName };
                ActivityTags.Add(newTag);
                SessionData.CurrentUser.Tags.Add(newTag);
                TagName = string.Empty;
                RaisePropertyChanged("ActivityTags");
            }
        }

        public void RemoveSelectedTag()
        {
            if (SelectedTag != null)
            {
                ActivityTags.Remove(SelectedTag);
                //DataLayer.Instance.Tagsrepository.RemoveTag(SelectedTag);
                RaisePropertyChanged("ActivityTags");
            }
            else
            {
                MessageBox.Show("You need to select a tag to remove");
            }
        }

        private string _tagName;
        public string TagName
        {
            get { return _tagName; }
            set
            {
                _tagName = value;
                RaisePropertyChanged("TagName");
            }
        }

        private EntityCollection<Tag> _activityTags;
        public EntityCollection<Tag> ActivityTags
        {
            get { return _activityTags; }
            set
            {
                _activityTags = value;
                RaisePropertyChanged("ActivityTags");
            }
        }

        private Tag _selectedTag;
        public Tag SelectedTag
        {
            get { return _selectedTag; }
            set
            {
                _selectedTag = value;
                RaisePropertyChanged("SelectedTag");
            }
        }

        public bool NameIsValid(string tagname)
        {
            bool iSValid = true;
            if(ActivityTags != null)
            {
                foreach (var tag in ActivityTags)
                {
                    if (tagname == string.Empty || tag.Name == tagname)
                    {
                        iSValid = false;
                    }
                }
            }

            return iSValid;
        }

        public void ClickAllActivities()
        {
            Messenger.Default.Send(new SwitchViewMessage { ShowControl = WindowViews.AddActivities });
        }
    }
}
