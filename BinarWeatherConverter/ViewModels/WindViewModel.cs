using BinarWeatherConverter.Models;

namespace BinarWeatherConverter.ViewModels
{
    public class WindViewModel : BaseViewModel
    {
        public WindModel? Wind { get; set; }
        public WindModel? ForecastWind { get; set; }

        public override void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains("KT") && item.Length > 4)
                    Wind = new(item);
            }
        }

        public override void Evaluate(string data, bool isForecast)
        {
            if (data.Contains("Calm") || data.Contains("kt"))
                ForecastWind = new(data, isForecast);
        }
    }
}
