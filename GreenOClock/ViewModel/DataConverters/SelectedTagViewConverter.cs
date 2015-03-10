using System;
using System.Globalization;
using System.Windows.Data;
using GreenOClock.Views;

namespace GreenOClock.ViewModel
{
    [ValueConversion(typeof(Tag), typeof(TagView))]
    class SelectedTagViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tagDisplayObject = new TagView();

            if (value == null)
            {
                return tagDisplayObject;
            }

            var tagListItem = (Tag)value;
            tagDisplayObject.TagNameBox.Content = tagListItem.Name;
            tagDisplayObject.TagIdBox.Content = tagListItem.TagId;

            return tagDisplayObject;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var tagListItem = new Tag();

            if (value == null)
            {
                return tagListItem;
            }

            var tagDisplayObject = (TagView)value;

            tagListItem.Name = tagDisplayObject.TagNameBox.Content.ToString();
            tagListItem.TagId = int.Parse(tagDisplayObject.TagIdBox.Content.ToString());

            return tagListItem;
        }
    }
}
