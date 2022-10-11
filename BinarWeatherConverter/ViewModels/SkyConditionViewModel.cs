using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class SkyConditionViewModel
    {
        public ObservableCollection<SkyConditionModel> SkyConditions { get; set; } = new();
        internal void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Contains("SKC") || item.Contains("FEW") || item.Contains("SCT")
                    || item.Contains("BKN") || item.Contains("OVC"))
                {
                    SkyConditionModel newSkyCondition = new(item);
                    SkyConditions.Add(newSkyCondition);
                }
            }
        }
    }
}
