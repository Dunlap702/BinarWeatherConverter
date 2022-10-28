using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class DateTimeViewModel
    {
        public DateTimeModel? DateTime { get; set; }
        internal void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains('/') && item.Length == 9 && !item.Contains("TN") && !item.Contains("TX"))
                {
                    DateTime = new(item);
                    break;
                }
            }
        }
    }
}
