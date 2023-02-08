using BinarWeatherConverter.Models;
using System.Text.RegularExpressions;

namespace BinarWeatherConverter.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        public TemperatureModel? Temperature { get; set; }
        public TemperatureModel? ForecastedTemp { get; set; }

        public override void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains("TX") || item.Contains("TN"))
                {
                    Temperature = new(item);
                }
            }
        }

        public override void Evaluate(string data, bool isMaxTemp)
        {
            if (data.Contains('/'))
            {
                var replacedData = Regex.Replace(data, @"Â", "");
                replacedData = Regex.Replace(replacedData, @"M", "-");

                ForecastedTemp = new(replacedData, isMaxTemp);
            }
        }
    }
}
