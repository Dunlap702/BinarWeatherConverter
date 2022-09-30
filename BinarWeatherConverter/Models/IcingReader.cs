using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace BinarWeatherConverter.Models
{
    internal class IcingReader
    {
        internal static string GetIcing(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.StartsWith('6') && !item.Contains('+'))
                    result = item;
            }
            return result;
        }
    }
}
