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
            { "UP", "Unknown" },
            { "VC", "Vicinity" },
            { "MI", "Shallow" },
            { "DR", "Drifting" },
            { "BL", "Blowing" },
            { "PR", "Partial" },

            { "PO", "Dust Devil" },
            { "SQ", "Squall" },
            { "BC", "Patches" },
            { "DZ", "Drizzle" },
            { "HZ", "Haze" },
            { "FU", "Smoke" },
            { "BR", "Mist" },
            { "FG", "Fog" },
            { "DU", "Dust" },
            { "SA", "Sand" },
            { "PY", "Spray" },

            { "SH", "Showers" },
            { "RA", "Rain" },
            { "SN", "Snow" },
            { "SG", "Snow Grains" },
            { "IC", "Ice Crystals" },
            { "PL", "Ice Pellets" },
            { "GR", "Hail" },
            { "GS", "Snow pellets" },
            { "SS", "Sandstorm" },
            { "TS", "Thunderstorm" },
            { "FZ", "Freezing" },
            { "FC", "Funnel Cloud" },
            { "DS", "Dust Storm" },
            { "VA", "Volcanic Ash" }
        };
    }
}
