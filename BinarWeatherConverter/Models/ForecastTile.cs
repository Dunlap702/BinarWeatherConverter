using BinarWeatherConverter.ViewModels;
using System.Collections.Generic;

namespace BinarWeatherConverter.Models
{
    public class ForecastTile
    {
        public bool isForecast = true;
        public bool isMaxTemp = true;
        public DateTimeViewModel DateTimeVM { get; set; } = new();
        public SkyConditionViewModel SkyConditionVM { get; set; } = new();
        public WindViewModel WindViewModel { get; set; } = new();
        public TemperatureViewModel MaxTempVM { get; set; } = new();
        public TemperatureViewModel MinTempVM { get; set; } = new();

        // MaxTemp: "Max: 61degreesF / 16degreesC
        // MinTemp: "Min: 14degreesF / M10degreesC

        public ForecastTile(List<string> listOfItems)
        {
            //Eval properties
            DateTimeVM.Evaluate(listOfItems[0], isForecast);
            SkyConditionVM.Evaluate(listOfItems[2], isForecast);
            WindViewModel.Evaluate(listOfItems[5], isForecast);
            MaxTempVM.Evaluate(listOfItems[6], isMaxTemp);
            MinTempVM.Evaluate(listOfItems[7], isMaxTemp = false);
        }
    }
}
