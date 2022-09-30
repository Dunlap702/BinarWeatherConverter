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
        internal static int GetTimeOne(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains('/'))
                    result = item[2].ToString() + item[3].ToString();
            }
            return (Convert.ToInt32(result)) - 7;
        }

        internal static int GetTimeTwo(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains('/'))
                    result = item[7].ToString() + item[8].ToString();
            }
            // 7 hours is subtracted from the time because the current file
            // displays time in Zulu time which is 7 hours ahead of PST.
            return (Convert.ToInt32(result)) - 7;
        }

        internal static int GetDateOne(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains('/'))
                    result = item[0].ToString() + item[1].ToString();
            }
            return Convert.ToInt32(result);
        }

        internal static int GetDateTwo(string[] data)
        {
            var result = "";
            foreach (var item in data)
            {
                if (item.Contains('/'))
                    result = item[5].ToString() + item[6].ToString();
            }
            return Convert.ToInt32(result);
        }
    }
}

