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
        public TemperatureViewModel TemperatureVM { get; set; } = new();
        public VisibilityViewModel VisibilityVM { get; set; } = new();


        public WeatherTile(string[] data)
        {
            DateTimeVM.Evaluate(data);
            StationStatusVM.Evaluate(data);
            SkyConditionVM.Evaluate(data);
            VisibilityVM.Evaluate(data);
            WindVM.Evaluate(data);
            TurbulenceVM.Evaluate(data);
            IcingVM.Evaluate(data);

            //Used to set a background image for codes without a sky condition (Station Status = Temp)
            if (SkyConditionVM.Condition == null)
                SkyConditionVM.Condition = new("SKC");
        }
    }
}
