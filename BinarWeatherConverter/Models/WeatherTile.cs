using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    public class WeatherTile
    {
        public int FirstTimeDisplay { get; set; }
        public int SecondTimeDisplay { get; set; }
        public int FirstDateDisplay { get; set; }
        public int SecondDateDisplay { get; set; }
        public string TimeStatusDisplay { get; set; }
        public string WindDisplay { get; set; }
        public string VisibilityDisplay { get; set; }
        public string SkyConditionDisplay { get; set; }
        public string TurbulenceDisplay { get; set; }
        public string IcingDisplay { get; set; }
        public string MaxTempDisplay { get; set; }
        public string MinTempDisplay { get; set; }


        public WeatherTile(string[] data)
        {
            FirstTimeDisplay = DateTimeReader.GetTimeOne(data);
            SecondTimeDisplay = DateTimeReader.GetTimeTwo(data);
            FirstDateDisplay = DateTimeReader.GetDateOne(data);
            SecondTimeDisplay = DateTimeReader.GetDateTwo(data);
            TimeStatusDisplay = TimeStatusReader.GetTimeStatus(data);
            WindDisplay = WindReader.GetWind(data);
            VisibilityDisplay = VisibilityReader.GetVisibility(data);
            SkyConditionDisplay = SkyConditionReader.GetSkyCondition(data);
            TurbulenceDisplay = TurbulenceReader.GetTurbulence(data);
            IcingDisplay = IcingReader.GetIcing(data);
            MaxTempDisplay = MaxTempReader.GetMaxTemp(data);
            MinTempDisplay = MinTempReader.GetMinTemp(data);
        }
    }
}
