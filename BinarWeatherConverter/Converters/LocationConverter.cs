using BinarWeatherConverter.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace BinarWeatherConverter.Converters
{
    public class LocationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string ret = "Binar Weather Converter";
            if (value is MainViewModel.LocationType type)
            {
                if (type == MainViewModel.LocationType.Station3)
                    return $"{ret} - Station 3";
                else if (type == MainViewModel.LocationType.Station7)
                    return $"{ret} - Station 7";
                else if (type == MainViewModel.LocationType.Example)
                    return $"{ret} - Example";
            }
            return ret;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
