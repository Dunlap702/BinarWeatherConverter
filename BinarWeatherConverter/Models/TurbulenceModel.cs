namespace BinarWeatherConverter.Models
{
    public class TurbulenceModel
    {
        public int Severity { get; set; }
        public int Altitude { get; set; }
        public int Thickness { get; set; }
        public string? Display { get; set; }

        public string GetIntensity
        {
            get
            {
                return Severity switch
                {
                    0 => "No Turbulence",
                    1 => "Light\nTurbulence",
                    2 => "Moderate\nTurbulence",
                    3 => "Moderate+\nTurbulence",
                    4 => "Mod/Severe\nTurbulence",
                    5 => "Mod/Severe+\nTurbulence",
                    6 => "Severe\nTurbulence",
                    7 => "Severe+\nTurbulence",
                    8 => "Extreme\nTurbulence",
                    9 => "Deadly\nTurbulence",
                    _ => "No Turbulence",
                };
            }
        }

        public TurbulenceModel(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                Severity = int.Parse(item[1..2]);
                Altitude = int.Parse(item[2..5]);
                Thickness = int.Parse(item[5..]);
                Display = $"{GetIntensity}";
            }
        }
    }
}