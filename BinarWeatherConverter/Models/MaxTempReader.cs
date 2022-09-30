using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    internal class MaxTempReader
    {
        internal static string GetMaxTemp(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if(item.Contains("TX"))
                    result = item;
            }
            return result;
        }
    }
}
