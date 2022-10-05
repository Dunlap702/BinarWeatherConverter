using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace BinarWeatherConverter.Models
{
    internal class DateTimeReader
    {

        internal static string GetFirstDateTime(string[] data)
        {
            var result = "";            
            foreach (var item in data)
            {
                if (item.Contains('/') && item.Length == 9)
                    result = item[0].ToString() + item[1].ToString() +
                        item[2].ToString() + item[3].ToString();
            }
            return result;
        }

        internal static string GetSecondDateTime(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains('/') && item.Length == 9)
                    result = item[5].ToString() + item[6].ToString() +
                        item[7].ToString() + item[8].ToString();
            }
            return result;
        }
        
    }
}

