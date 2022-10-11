using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class WindViewModel
    {
        public ObservableCollection<WindModel> Wind { get; set; } = new();

        internal void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains("KT") || (item[3] == 'V'))
                {
                    WindModel newWind = new(item);
                    Wind.Add(newWind);
                }    
            }
        }
    }
}
