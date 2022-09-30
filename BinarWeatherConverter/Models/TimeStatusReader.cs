using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    internal class TimeStatusReader
    {
        internal static string GetTimeStatus(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains("BECMG"))
                    result = item;
                else if (item.Contains("TEMPO"))
                    result = item;
            }
            return result;
        }
    }
}
