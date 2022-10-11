using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BinarWeatherConverter.Models
{
    public class DateTimeModel
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTimeModel(string item)
        {

            if (!string.IsNullOrEmpty(item))
            {
                StartTime = DateTime.ParseExact(item.Substring(0, 4), "ddHH", null);
                EndTime = DateTime.ParseExact(item.Substring(5, 4), "ddHH", null);
                StartTime = StartTime.AddHours(-7);
                EndTime = EndTime.AddHours(-7);
            }
        }
    }
}
