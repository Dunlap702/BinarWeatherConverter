using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinarWeatherConverter.ViewModels
{
    public class MainViewModel
    {
        
        public ObservableCollection<WeatherTile> MyWeatherTiles { get; } = new();
        public string[]? StationData { get; set; }
        public string path = "code1.txt";

        public void ReadFile()
        {
            var fileData = FileReader.ReadFile(path);
            //Pro-Tip:  verify you have data here before using it
            StationData = fileData[1];

            for (int i = 1; i < fileData.Count; i++)
            {
                string[]? lineOfSplitData = fileData[i];
                //analyze each and make a tile
                WeatherTile tile = new(lineOfSplitData);
                MyWeatherTiles.Add(tile);
            }
        }
    }
}
