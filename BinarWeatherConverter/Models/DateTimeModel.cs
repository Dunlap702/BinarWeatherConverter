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
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public DateTimeModel(string item)
        {
            string timeOne;
            string timeTwo;
            //string.IsNullOrEmpty(item), and also verify length again
            if (item != null)
            {
                // the string data is somehow being listed as int?
                timeOne = item.Substring(0, 2);
                timeTwo = item.Substring(7, 2);
                StartTime = new(Convert.ToInt32(timeOne), 00);
                EndTime = new(Convert.ToInt32(timeTwo), 00);
                //The next two don't actually do anything.   Should be StartTime = StartTime.AddHours() etc
                StartTime.AddHours(-7);
                EndTime.AddHours(-7);
            }
        }
    }
}
