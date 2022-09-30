using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class MainViewModel
    {
        
        public ObservableCollection<WeatherTile> MyWeatherTiles = new();
        public string path = "taf3.txt";
        public void ReadFile()
        {
            var fileData = FileReader.ReadFile(path);

            foreach(var lineOfSplitData in fileData)
            {
                //analyze each and make a tile
                WeatherTile tile = new(lineOfSplitData);
                MyWeatherTiles.Add(tile);
            }
        }
    }
}
