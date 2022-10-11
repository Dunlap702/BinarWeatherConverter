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
        //Pro-Tip:  I'm pretty sure there's only 1 wind reading, no need for a collection
        public ObservableCollection<WindModel> Wind { get; set; } = new();

        internal void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                //Pro-Tip:  what happens if the item only has a lenght of 2?  This crashes
                if (item.Contains("KT") || (item[3] == 'V'))
                {
                    WindModel newWind = new(item);
                    Wind.Add(newWind);
                }    
            }
        }
    }
}
