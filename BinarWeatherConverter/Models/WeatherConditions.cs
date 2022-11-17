using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class WeatherConditions
    {
        public string? Condition { get; set; }
        public string? Intensity { get; set; }
        public string Description { get; set; }
        public int Severity { get; set; }
        public string? Image => $@"pack://application:,,,/Images/WeatherIcons/{Description}.png";

        public WeatherConditions(string item)
        {
            Condition = item;
            Description = WeatherCodes.GetDescription(item.Substring((item.Length - 2), 2));
            Severity = WeatherCodes.GetSeverity(Description);
            if (item.Contains('+'))
                Intensity = "Heavy";
            else if (item.Contains('-'))
                Intensity = "Light";
        }
    }
}
