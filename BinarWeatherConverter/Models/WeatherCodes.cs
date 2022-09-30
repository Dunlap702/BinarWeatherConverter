using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public static class WeatherCodes
    {
        public static string GetDescription(string code) => Codes.FirstOrDefault(x => x.Key == code).Value;
        
        public static readonly Dictionary<string, string> Codes = new()
        {
            { "VC", "Vicinity" },
            { "BC", "Patches" },
            { "BL", "Blowing" },
            { "DR", "Low Drifting" },
            { "FZ", "Freezing" },
            { "MI", "Shallow" },
            { "PR", "Partial" },
            { "SH", "Showers" },
            { "TS", "Thunderstorm" },

            { "DZ", "Drizzle" },
            { "GR", "Hail" },
            { "GS", "Small Hail" },
            { "IC", "Ice Crystals" },
            { "PL", "Ice Pellets" },
            { "RA", "Rain" },
            { "SG", "Snow Grains" },
            { "SN", "Snow" },
            { "UP", "Unknown" },

            { "BR", "Mist" },
            { "DU", "Dust" },
            { "FG", "Fog" },
            { "FU", "Smoke" },
            { "HZ", "Haze" },
            { "PY", "Spray" },
            { "SA", "Sand" },
            { "VA", "Volcanic Ash" },
            { "DS", "Dust Storm" },
            { "FC", "Funnel Cloud" },
            { "PO", "Sand Whirls" },
            { "SQ", "Squalls" },
            { "SS", "Sandstorm" }
        };
    }
}
