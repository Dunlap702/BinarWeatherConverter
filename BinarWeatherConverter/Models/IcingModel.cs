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
                    0 => "No \nIcing",
                    1 => "Light \nIcing",
                    2 => "Moderate \nIcing",
                    3 => "Moderate+ \nIcing",
                    4 => "Mod/Severe \nIcing",
                    5 => "Mod/Severe+ \nIcing",
                    6 => "Severe \nIcing",
                    7 => "Severe+ \nIcing",
                    8 => "Extreme \nIcing",
                    9 => "Deadly \nIcing",
                    _ => "No Icing",
                };
            }
        }

        public IcingModel(string item)
        {
            if (!string.IsNullOrEmpty(item) && item.Length == 6)
            {
                Severity = int.Parse(item[1..2]);
                HeightOfIcing = int.Parse(item[2..5]);
                Thickness = int.Parse(item[5..]);
            }
        }
    }
}
