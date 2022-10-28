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

        public static int GetSeverity(string code)
        {
            if (Codes.ContainsKey(code))
            {
                var obj = Codes.FirstOrDefault(x => x.Key == code);
                return Codes.ToList().IndexOf(obj);
            }
            return 0;
        }

        public static readonly Dictionary<string, string> Codes = new()
        {
            //Intensity/Proximity
            { "VC", "Vicinity" },

            //Descriptors
            { "MI", "Shallow" },
            { "PR", "Partial" },
            { "BC", "Patches" },
            { "DR", "Drifting" },
            { "BL", "Blowing" },
            { "SH", "Showers" },
            { "TS", "Thunderstorm" },
            { "FZ", "Freezing" },

            //Precipitation
            { "DZ", "Drizzle" },
            { "RA", "Rain" },
            { "SN", "Snow" },
            { "SG", "Snow Grains" },
            { "IC", "Ice Crystals" },
            { "PL", "Ice Pellets" },
            { "GR", "Hail" },
            { "GS", "Snow pellets" },
            { "UP", "Unknown" },

            //Obsecurity
            { "BR", "Mist" },
            { "FG", "Fog" },
            { "FU", "Smoke" },
            { "VA", "Volcanic Ash" },
            { "DU", "Dust" },
            { "SA", "Sand" },
            { "HZ", "Haze" },
            { "PY", "Spray" },

            //Other
            { "PO", "Dust Devil" },
            { "SQ", "Squall" },
            { "FC", "Funnel Cloud" },
            { "SS", "Sandstorm" },
            { "DS", "Dust Storm" }
        };
    }
}
