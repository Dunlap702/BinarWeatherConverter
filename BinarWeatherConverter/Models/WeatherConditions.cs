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

        public WeatherConditions(string item)
        {
            Condition = item;
            if (item.Length == 3 || item.Length == 5)
            {
                Intensity = item[..1];
            }
            Description = WeatherCodes.GetDescription(item[-2..2]);
            Severity = WeatherCodes.GetSeverity(Description);
        }


    }
}
