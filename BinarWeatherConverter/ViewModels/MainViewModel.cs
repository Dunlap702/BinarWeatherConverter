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

        public string path = "code2.txt";

        public void ReadFile()
        {
            var fileData = FileReader.ReadFile(path);

            if (fileData != null && fileData.Count > 0)
            {
                for (int i = 0; i < fileData.Count; i++)
                {
                    string[]? lineOfSplitData = fileData[i];

                    WeatherTile tile = new(lineOfSplitData);
                    MyWeatherTiles.Add(tile);
                } 
            }
        }
    }
}
