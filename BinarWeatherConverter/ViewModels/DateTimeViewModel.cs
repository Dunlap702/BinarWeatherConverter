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
        internal void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains('/') && item.Length == 9)
                {
                    DateTimeModel newDateTimeModel = new(item);
                }
            }
        }
    }
}
