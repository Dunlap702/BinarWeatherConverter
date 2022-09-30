using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    internal class WindReader
    {
        internal static string GetWind(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains("KT") || item.Contains('V'))
                    result = item;
            }
            return result;
        }
    }
}
