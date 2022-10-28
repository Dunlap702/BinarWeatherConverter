using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class IcingViewModel
    {
        public ObservableCollection<IcingModel> Icing { get; set; } = new();

        public IcingModel? WorstCase
        {
            get
            {
                if (Icing.Any())
                {
                    IcingModel worst = Icing[0];

                    foreach (var i in Icing)
                        if (i.Severity > worst.Severity)
                            worst = i;
                    return worst;
                }
                return null;
            }
        }

        internal void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.StartsWith('6') && !item.Contains('+') && item.Length == 6)
                {
                    IcingModel newIcing = new(item);
                    Icing.Add(newIcing);
                }
            }
        }
    }
}
