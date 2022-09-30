using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    internal class TurbulenceReader
    {
        internal static string GetTurbulence(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.StartsWith('5') && !item.Contains('+'))
                    result = item;
            }
            return result;
        }
    }
}
