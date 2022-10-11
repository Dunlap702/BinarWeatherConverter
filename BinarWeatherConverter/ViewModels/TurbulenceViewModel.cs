using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class TurbulenceViewModel
    {
        public ObservableCollection<TurbulenceModel> Turbulence { get; set; } = new();

        public TurbulenceModel? WorstCase
        {
            get
            {
                if (Turbulence.Any())
                {
                    TurbulenceModel worst = Turbulence[0];

                    foreach (var t in Turbulence)
                        if (t.Severity > worst.Severity)
                            worst = t;
                    return worst;
                }
                return null;
            }
        }

        internal void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.StartsWith('5') && !item.Contains('+') && item.Length == 6)
                {
                    TurbulenceModel newTurb = new(item);
                    Turbulence.Add(newTurb);
                }
            }
        }
    }
}
