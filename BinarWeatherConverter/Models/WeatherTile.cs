using BinarWeatherConverter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class WeatherTile
    {
        public TurbulenceViewModel TurbulenceVM { get; set; } = new();
        public DateTimeViewModel DateTimeVM { get; set; } = new();
        public StationStatusViewModel StationStatusVM { get; set; } = new();
        public WindViewModel WindVM { get; set; } = new();
        public SkyConditionViewModel SkyConditionVM { get; set; } = new();
        public IcingViewModel IcingVM { get; set; } = new();


        public WeatherTile(string[] data)
        {
            TurbulenceVM.Evaluate(data);
            DateTimeVM.Evaluate(data);
            StationStatusVM.Evaluate(data);
            WindVM.Evaluate(data);
            IcingVM.Evaluate(data);
            // Evaluate Temperature (seperate min/max?)
        }
    }
}
