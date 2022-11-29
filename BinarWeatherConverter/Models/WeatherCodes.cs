using System.Collections.Generic;
using System.Linq;

namespace BinarWeatherConverter.Models
{
    public static class WeatherCodes
    {
        public static string GetDescription(string code) => Codes.FirstOrDefault(x => x.Key == code).Value;

        public static int GetSeverity(string code)
        {
            if (Codes.ContainsValue(code))
            {
                var obj = Codes.FirstOrDefault(x => x.Value == code);
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
            { "GS", "Snow Pellets" },
            { "SS", "Sandstorm" },
            { "TS", "Thunderstorm" },
            { "FZ", "Freezing" },
            { "FC", "Funnelcloud" },
            { "DS", "Duststorm" },
            { "VA", "Volcanic Ash" }
        };
    }
}
