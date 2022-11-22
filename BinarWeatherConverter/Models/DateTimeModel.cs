using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BinarWeatherConverter.Models
{
    public class DateTimeModel
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime ForecastDate { get; set; }

        public string AvationDisplay
        {
            get => $"{StartTime:HH:mm} to {EndTime:HH:mm}";
        }

        public DateTimeModel(string weatherItem)
        {
            if (!string.IsNullOrEmpty(weatherItem))
            {
                StartTime = DateTime.ParseExact(weatherItem.Substring(0, 4), "ddHH", null);
                EndTime = DateTime.ParseExact(weatherItem.Substring(5, 4), "ddHH", null);
                StartTime = StartTime.AddHours(-7);
                EndTime = EndTime.AddHours(-7);
            }
        }
        public DateTimeModel(string forecastItem, bool isForecastItem)
        {
            if (!string.IsNullOrEmpty(forecastItem) && isForecastItem == true)
                ForecastDate = DateTime.ParseExact(forecastItem, "ddd, dd MMM", null);
        }
    }
}
