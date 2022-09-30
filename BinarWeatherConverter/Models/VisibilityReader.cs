using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    internal class VisibilityReader
    {
        internal static string GetVisibility(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains('+'))
                    result = item;
            }

            return result;
        }
    }
}
