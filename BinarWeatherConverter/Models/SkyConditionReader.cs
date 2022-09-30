using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    internal class SkyConditionReader
    {
        internal static string GetSkyCondition(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains("SKC") || item.Contains("FEW") ||
                    item.Contains("SCT") || item.Contains("BKN") ||
                    item.Contains("OVC"))
                    result = item;
            }
            return result;
        }
    }
}
