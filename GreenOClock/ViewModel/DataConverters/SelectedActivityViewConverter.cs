using System;
using System.Globalization;
using System.Windows.Data;
using GreenOClock.Model;
using GreenOClock.Views;

namespace GreenOClock.ViewModel.DataConverters
{
    [ValueConversion(typeof(Activity), typeof(ActivityView))]
    class SelectedActivityViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var activityDisplayObject = new ActivityView();
            if (value == null)
                return activityDisplayObject;
            var activityListItem = (Activity) value;
            activityDisplayObject.ActivityName.Content = activityListItem.Name;
            foreach (var tag in activityListItem.Tags)
            {
                activityDisplayObject.ListOfTags.Items.Add(tag);
            }
            return activityDisplayObject;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var activityListItem = new Activity();
            if (value == null)
                return activityListItem;
            var activityDisplayObject = (ActivityView)value;
            activityListItem.Name = activityDisplayObject.ActivityName.Content.ToString();
            foreach (var tag in activityDisplayObject.ListOfTags.Items)
            {
                activityListItem.Tags.Add((Tag)tag);
            }
            return activityDisplayObject;
        }
    }
}
