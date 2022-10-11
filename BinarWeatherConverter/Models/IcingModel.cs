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
