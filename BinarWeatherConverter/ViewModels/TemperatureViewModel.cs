using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace BinarWeatherConverter.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        public TemperatureModel? Temperature { get; set; }

        public override void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if(item.Contains("TX") || item.Contains("TN"))
                {
                    Temperature = new(item);
                }
            }
        }
    }
}
