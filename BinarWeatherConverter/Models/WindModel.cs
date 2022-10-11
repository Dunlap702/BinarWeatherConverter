using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{

    public class WindModel
    {
        public string? DirectionOne { get; set; }
        public string? DirectionTwo { get; set; }
        public string? Status { get; set; }
        public int WindSpeedOne { get; set; }
        public int WindSpeedTwo { get; set; }

        public WindModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                if (item.Contains('G') && item.Contains("KT"))
                {
                    DirectionOne = GetDirection(Convert.ToInt32(item.Substring(0, 3)));
                    WindSpeedOne = Convert.ToInt32(item.Substring(3, 2));
                    WindSpeedTwo = Convert.ToInt32(item.Substring(6, 2));
                }
                else if (item.StartsWith("VRB"))
                {
                    Status = item.Substring(0, 3);
                    WindSpeedOne = Convert.ToInt32(item.Substring(3, 2));
                }
                else if (item[3] == 'V')
                {
                    DirectionOne = GetDirection(Convert.ToInt32(item.Substring(0, 3)));
                    Status = "Varying";
                    DirectionTwo = GetDirection(Convert.ToInt32(item.Substring(4, 3)));
                }
                else if (item.Contains("KT") && !item.StartsWith("00000"))
                {
                    DirectionOne = GetDirection(Convert.ToInt32(item.Substring(0, 3)));
                    WindSpeedOne = Convert.ToInt32(item.Substring(3, 2));
                }
                else
                    Status = "Calm";
            }
        }

        public string GetDirection(int value)
        {
            string sReturn = "N";
            if (value > 348 || value < 11.25)
                sReturn = "N";
            else if (value < 33.75)
                sReturn = "NNE";
            else if (value < 56.25)
                sReturn = "NE";
            else if (value < 78.75)
                sReturn = "ENE";
            else if (value < 101.25)
                sReturn = "E";
            else if (value < 123.75)
                sReturn = "ESE";
            else if (value < 146.25)
                sReturn = "SE";
            else if (value < 168.75)
                sReturn = "SSE";
            else if (value < 191.25)
                sReturn = "S";
            else if (value < 213.75)
                sReturn = "SSW";
            else if (value < 236.25)
                sReturn = "SW";
            else if (value < 258.75)
                sReturn = "WSW";
            else if (value < 281.25)
                sReturn = "W";
            else if (value < 303.75)
                sReturn = "WNW";
            else if (value < 326.25)
                sReturn = "NW";
            else if (value < 348.75)
                sReturn = "NNW";
            return sReturn;
        }
    }

}
