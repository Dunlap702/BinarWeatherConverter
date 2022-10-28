using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class VisibilityModel
    {
        public string? Visibility { get; set; }

        public VisibilityModel(string item)
        {
            if (string.IsNullOrEmpty(item))
                Visibility = item;
        }
    }
}
