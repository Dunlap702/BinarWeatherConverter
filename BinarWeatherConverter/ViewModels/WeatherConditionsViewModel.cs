using BinarWeatherConverter.Models;
using System.Collections.Generic;
using System.Linq;

namespace BinarWeatherConverter.ViewModels
{
    public class WeatherConditionsViewModel : BaseViewModel
    {
        public WeatherConditions? WorstWeather { get; set; }
        public List<WeatherConditions> WeatherConditions { get; set; } = new();

        public override void Evaluate(string[] data)
        {
            //input type ex: "SN", "+SN", "BLSN", "+BLSN"
            foreach (var item in data)
            {
                if ((item.Length > 1 && item.Length <= 4) || (item.Length == 5 && (item.Contains('+') || item.Contains('-'))))
                {
                    var last2 = item.Substring(item.Length - 2, 2);

                    if (WeatherCodes.Codes.ContainsKey(last2))
                    {
                        WeatherConditions Condition = new(item);
                        WeatherConditions.Add(Condition);
                    }
                }
            }
            WorstWeather = (WeatherConditions?)WorstCase();
        }

        public override object? WorstCase()
        {
            if (WeatherConditions.Any())
            {
                int currentSeverity = 0;
                foreach (var item in WeatherConditions)
                    if (item.Severity > currentSeverity)
                        WorstWeather = item;
                return WorstWeather;
            }
            return null;
        }
    }
}
