using System;

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
            // Avation codes will use 2400 for midnight which is not a valid time.
            if (weatherItem.Contains("24"))
                weatherItem = weatherItem.Replace("24", "00");

            if (!string.IsNullOrEmpty(weatherItem))
            {
                StartTime = DateTime.ParseExact(weatherItem[..4], "ddHH", null);
                EndTime = DateTime.ParseExact(weatherItem.Substring(5, 4), "ddHH", null);

                // Adjust for Zulu time to local time
                StartTime = StartTime.ToLocalTime();
                EndTime = EndTime.ToLocalTime();
            }
        }
        public DateTimeModel(string forecastItem, bool isForecastItem)
        {
            if (!string.IsNullOrEmpty(forecastItem) && isForecastItem == true)
                ForecastDate = DateTime.ParseExact(forecastItem, "ddd, dd MMM", null);
        }
    }
}
