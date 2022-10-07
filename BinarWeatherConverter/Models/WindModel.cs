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
            if (item.Contains('G'))
            {
                DirectionOne = GetDirection(item.Substring(0, 3));
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
                DirectionOne = GetDirection(item.Substring(0, 3));
                Status = "Varying";
                DirectionTwo = GetDirection(item.Substring(4, 3));
            }
            else
                Status = "Calm";
        }

        public string GetDirection(string degrees)
        {
            var result = "";
            switch (degrees)
            {
                case "0":
                    result = "N";
                    break;
                case "45":
                    result = "NE";
                    break;
                case "90":
                    result = "E";
                    break;
                case "135":
                    result = "SE";
                    break;
                case "180":
                    result = "S";
                    break;
                case "225":
                    result = "SW";
                    break;
                case "270":
                    result = "E";
                    break;
                case "315":
                    result = "NE";
                    break;
            }
            return result;
        }
    }

}
