﻿using System;
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
            if (item != null)
            {
                Severity = Convert.ToInt32(item[1]);
                Altitude = Convert.ToInt32(item.Substring(2,3));
                Thickness = Convert.ToInt32(item[5]);
            }
        }
    }
}