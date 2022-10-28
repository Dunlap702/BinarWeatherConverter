using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class VisibilityViewModel
    {
        public VisibilityModel? Visbility { get; set; }

        internal void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains('+') && item.Length < 3)
                    Visbility = new(item);
            }
        }
    }
}
