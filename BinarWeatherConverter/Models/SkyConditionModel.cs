using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class SkyConditionModel
    {
        public string? Conditon { get; set; }
        public int BaseHeight { get; set; } = 0;

        public SkyConditionModel(string item)
        {
            if (item != null)
            {
                Conditon = item.Substring(0, 3);
                if (Conditon != "SKC")
                    BaseHeight = Convert.ToInt32(item.Substring(3,3));
            }
        }
    }
}
