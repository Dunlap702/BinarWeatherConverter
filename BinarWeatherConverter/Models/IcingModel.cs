using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class IcingModel
    {
        public int Severity { get; set; }
        public int HeightOfIcing { get; set; }
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

        public IcingModel(string item)
        {
            if (!string.IsNullOrEmpty(item) && item.Length == 6)
            {
                Severity = Convert.ToInt32(item[1]);
                HeightOfIcing = Convert.ToInt32(item.Substring(2, 3));
                Thickness = Convert.ToInt32(item[5]);
            }
        }
    }
}
