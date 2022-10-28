using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class SkyConditionModel
    {
        public string? Conditon { get; set; } = "SKC";
        public int BaseHeight { get; set; } = 0;
        public string? Display { get; set; }
        //pack://application:,,,/BinarWeatherConverter;component/Images/image_to_use.png
        //Set the background of the tile
        public string? Image => $@"pack://application:,,,/Images/Backgrounds/{Conditon}.png";

        public SkyConditionModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                Conditon = item[..3];
                if (Conditon != "SKC")
                {
                    BaseHeight = Convert.ToInt32(item.Substring(3, 2));
                    Display = $"{Conditon} {BaseHeight}k ft";
                }

            }
        }
    }
}
