using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class VisibilityViewModel : BaseViewModel
    {
        public VisibilityModel? Visbility { get; set; }

        public override void Evaluate(string[] data)
        {
            foreach (string item in data)
            {
                if (item.Length == 1 || (item.Length == 2 && item.Contains('+')))
                    Visbility = new(item);
            }
        }
    }
}
