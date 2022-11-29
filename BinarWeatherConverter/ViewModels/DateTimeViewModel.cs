using BinarWeatherConverter.Models;

namespace BinarWeatherConverter.ViewModels
{
    public class DateTimeViewModel : BaseViewModel
    {
        public DateTimeModel? DateTime { get; set; }
        public override void Evaluate(string[] data)
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
        public override void Evaluate(string data, bool isForecast)
        {
            if (data.Contains(',') && data.Length < 12)
            {
                DateTime = new(data, isForecast);
            }
        }
    }
}
