using System;
using System.Linq;

namespace BinarWeatherConverter.Models
{
    public class TurbulenceModel
    {
        public int Severity { get; set; }
        public int Altitude { get; set; }
        public int Thickness { get; set; }

        public string GetIntensity
        {
            get
            {
                return Severity switch
                {
                    0 => "None",
                    1 => "Light",
                    2 => "Moderate",
                    3 => "Moderate+",
                    4 => "Mod/Severe",
                    5 => "Mod/Severe+",
                    6 => "Severe",
                    7 => "Severe+",
                    8 => "Extreme",
                    9 => "Deadly",
                    _ => "None",
                };
            }
        }

        public string Display
        {
            get
            {
                return $"Turb: {Severity}";
            }
        }

        public TurbulenceModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                Severity = int.Parse(item[1..2]);
                Altitude = int.Parse(item[2..5]);
                Thickness = int.Parse(item[5..]);
            }
        }
    }
}