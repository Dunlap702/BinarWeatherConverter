namespace BinarWeatherConverter.Models
{
    public class StationStatusModel
    {
        public string? StationStatus { get; set; }

        public StationStatusModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
                StationStatus = item;
        }
    }
}
