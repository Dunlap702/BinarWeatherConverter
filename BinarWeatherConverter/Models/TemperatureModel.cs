using System;

namespace BinarWeatherConverter.Models
{
    public class TemperatureModel
    {
        public int MaxTemp { get; set; }
        public int MinTemp { get; set; }
        public DateTime MaxTempDateTime { get; set; }
        public DateTime MinTempDateTime { get; set; }
        public string? ForecastMaxTemp { get; set; }
        public string? ForecastMinTemp { get; set; }

        public TemperatureModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                if (item.StartsWith("TX"))
                {
                    MaxTemp = Convert.ToInt32(item.Substring(2, 2));
                    MaxTempDateTime = DateTime.ParseExact(item.Substring(5, 4), "ddHH", null);
                }
                else if (item.StartsWith("TN"))
                {
                    MinTemp = Convert.ToInt32(item.Substring(2, 2));
                    MinTempDateTime = DateTime.ParseExact(item.Substring(5, 4), "ddHH", null);
                }
            }
        }
        public TemperatureModel(string item, bool isMaxTemp)
        {
            if (!string.IsNullOrEmpty(item))
            {
                if (isMaxTemp)
                    ForecastMaxTemp = item;
                else
                    ForecastMinTemp = item;
            }
        }
    }
}
