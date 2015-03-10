using System;
using System.Collections.ObjectModel;
using System.Data.Objects.DataClasses;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using GreenOClock.Views;

namespace GreenOClock.ViewModel.DataConverters
{
    [ValueConversion(typeof(EntityCollection<Activity>), typeof(ObservableCollection<ActivityView>))]
    class ActivityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var activityCollection = (EntityCollection<Activity>)value;
            var activityViewCollection = new ObservableCollection<ActivityView>();
            if (value == null)
                return activityViewCollection;
            foreach (var activity in activityCollection)
            {
                var activityview = new ActivityView();
                activityview.ActivityName.Content = activity.Name;
                foreach (var tag in activity.Tags)
                {
                    var newTagView = new TagView();
                    newTagView.TagNameBox.Content = tag.Name;
                    activityview.ListOfTags.Items.Add(newTagView);
                }

                activityViewCollection.Add(activityview);
            }
            return activityViewCollection;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var activityCollection = new ObservableCollection<Activity>();
            if (value == null)
                return activityCollection;
            var activityViewCollection = (ObservableCollection<ActivityView>)value;
            foreach (var activityView in activityViewCollection)
            {
                var activity = new Activity();
                activity.Name = activityView.ActivityName.Content.ToString();
                //DataLayer.Instance.ActivitiesTagsRepository.AddTagsToActivity(ListBoxItemsFromContainerGenerator(activityView.ListOfTags, activity), activity);
                activityCollection.Add(activity);
            }
            return activityCollection;
        }

        private EntityCollection<Tag> ListBoxItemsFromContainerGenerator(ListBox listbox, Activity activity)
        {
            //var activityTags = DataLayer.Instance.ActivitiesTagsRepository.GetTagsForActivity(activity) as EntityCollection<Tag>;
            //for (var i = 0; i < listbox.Items.Count; i++)
            //{
            //    var item = (listbox.ItemContainerGenerator.ContainerFromIndex(i)) as ListBoxItem;
            //    var newTag = new Tag();
            //    newTag.TagName = (string)item.Content;
            //    activityTags.Add(newTag);
            //}
            //return activityTags;
            return null;
        }
    }
}
