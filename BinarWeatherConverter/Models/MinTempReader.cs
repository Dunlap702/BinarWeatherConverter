using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    internal class MinTempReader
    {
        internal static string GetMinTemp(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains("TN"))
                    result = item;
            }
            return result;
        }
    }
}
