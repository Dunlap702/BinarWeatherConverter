using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class StationStatusModel
    {
        public string? StationStatus { get; set; }

        public StationStatusModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
                StationStatus = item;
        }
    }
}
