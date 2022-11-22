using System;

namespace BinarWeatherConverter.Models
{
    public class SkyConditionModel
    {
        public string? Condition { get; set; } = "SKC";
        public int BaseHeight { get; set; } = 0;
        public string? AvationDisplay { get; set; }
        public string? ForecastDisplay { get; set; }
        public string? Image => $@"pack://application:,,,/Images/Backgrounds/{Condition}.png";
        public string? ForecastImage => $@"pack://application:,,,/Images/WeatherIcons/{ForecastDisplay}.png";

        public SkyConditionModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                Condition = item[..3];
                if (Condition != "SKC")
                {
                    BaseHeight = Convert.ToInt32(item.Substring(3, 2));
                    AvationDisplay = $"{Condition} {BaseHeight}k ft";
                }
            }
        }

        public SkyConditionModel(string item, bool isForecast)
        {
            if (!string.IsNullOrEmpty(item) && isForecast == true)
            {
                ForecastDisplay = item;
            }
        }

    }
}
