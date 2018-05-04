using System;
using System.Globalization;
using WeatherApp.Core.Models;
using Xamarin.Forms;

namespace WeatherApp.Core.Converters
{
    public class ConditionsToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromFile(((Conditions)value).ToString().ToLower());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
