namespace BinarWeatherConverter.Models
{
    public class VisibilityModel
    {
        public string? Visibility { get; set; }

        public VisibilityModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
                Visibility = item;
        }
    }
}
