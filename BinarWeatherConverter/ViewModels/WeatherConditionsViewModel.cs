using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class WeatherConditionsViewModel : BaseViewModel
    {
        public WeatherConditions? WorstWeather { get; set; }
        public List<WeatherConditions> WeatherConditions { get; set; } = new();
        public override void Evaluate(string[] data)
        {
            //string input1 = "SN";
            //string input2 = "+SN";
            //string input3 = "BLSN";
            //string input4 = "+BLSN";

            foreach (var item in data)
            {
                if (item.Length > 1 && item.Length <= 5)
                {
                    //Pull out the last 2 characters
                    var last2 = item.Substring(item.Length - 2, 2);

                    //We know this is a valid case
                    if (WeatherCodes.Codes.ContainsKey(last2))
                    {
                        WeatherConditions Conditions = new(item);
                        WeatherConditions.Add(Conditions);
                        //Determine if we're heavy (+) or light (-)
                        if (item.Contains('+'))
                            Conditions.Intensity = "Heavy";
                        else if (item.Contains('-'))
                            Conditions.Intensity = "Light";

                        //Determine if there's more than 1 code in there
                    }
                }
            }

        }
        public override object WorstCase()
        {
            int currentSeverity = 0;
            if (WeatherConditions != null)
            {
                foreach (var item in WeatherConditions)
                {
                    if (item.Severity > currentSeverity)
                        WorstWeather = item;
                }
            }
            return 0;
        }
    }
}
