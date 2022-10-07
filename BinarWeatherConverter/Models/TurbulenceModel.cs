using System;
using System.Linq;

namespace BinarWeatherConverter.Models
{
    public class TurbulenceModel
    {
        public int Severity { get; set; }
        public int Altitude { get; set; }
        public int Thickness { get; set; }

        public TurbulenceModel(string item)
        {
            string tempAlt;

            // the string data is somehow being listed as int?

            if (item != null)
            {
                tempAlt = item[2].ToString() + item[3].ToString() + item[4].ToString();

                Severity = Convert.ToInt32(item[1]);
                Altitude = Convert.ToInt32(tempAlt);
                Thickness = Convert.ToInt32(item[5]);
            }
        }
    }
}