using BinarWeatherConverter.Models;
using System.Collections.ObjectModel;

namespace BinarWeatherConverter.ViewModels
{
    public class SkyConditionViewModel : BaseViewModel
    {
        public ObservableCollection<SkyConditionModel> SkyConditions { get; set; } = new();
        public SkyConditionModel? Condition { get; set; }
        public SkyConditionModel? ForecastCondition { get; set; }

        public override void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains("SKC") || item.Contains("FEW") || item.Contains("SCT")
                    || item.Contains("BKN") || item.Contains("OVC"))
                {
                    Condition = new(item);
                    SkyConditions.Add(Condition);
                }
            }
        }
        public override void Evaluate(string data, bool isForecast)
        {
            switch (data)
            {
                case "Clear":
                case "Mostly Sunny":
                case "Partly Cloudy":
                case "Cloudy":
                    ForecastCondition = new(data, isForecast); 
                    break;
                default: break;
            }
        }
    }
}
