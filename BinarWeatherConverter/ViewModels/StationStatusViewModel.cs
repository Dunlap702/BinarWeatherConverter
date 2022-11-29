using BinarWeatherConverter.Models;

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
