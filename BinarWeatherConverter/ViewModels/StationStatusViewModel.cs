using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class StationStatusViewModel : BaseViewModel
    {
        public StationStatusModel? StationStatus { get; set; }

        public override void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains("BEC") || item.Contains("TEMP") ||
                        item.Contains("STA"))
                {
                    StationStatus = new(item);
                    break;
                }
            }
        }
    }
}
