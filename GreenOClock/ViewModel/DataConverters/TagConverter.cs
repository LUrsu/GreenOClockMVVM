using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Objects.DataClasses;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using GreenOClock.Views;

namespace GreenOClock.ViewModel
{
    [ValueConversion(typeof(EntityCollection<Tag>), typeof(ObservableCollection<TagView>))]
    class TagConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var displayTags = new ObservableCollection<TagView>();
            if(value==null)
            {
                return displayTags;
            }
            foreach (var tagListObject in (EntityCollection<Tag>)value )
            {
                var tagDisplayObject = new TagView();
                tagDisplayObject.TagNameBox.Content = tagListObject.Name;
                displayTags.Add(tagDisplayObject);
            }
            return displayTags;
        }



        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
