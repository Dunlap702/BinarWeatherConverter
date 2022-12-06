using BinarWeatherConverter.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BinarWeatherConverter.ViewModels
{
    public class MainViewModel
    {

        public ObservableCollection<WeatherTile> MyWeatherTiles { get; } = new();
        public ObservableCollection<ForecastTile> MyFocastTiles { get; } = new();

        public List<string> codeFilePaths = new();
        public string exampleAviation = "AviationCodeExample.txt";
        public string exampleForecast = "ForecastExample.txt";


        public void ReadFile()
        {
            var filePaths = FileReader.ReadPathsFile("FilePaths.txt");
            if (filePaths != null && filePaths.Count > 0)
            {
                foreach (var file in filePaths)
                    codeFilePaths.Add(file[1]);
            }
        }

        public void GetTiles(string station)
        {
            if (station.Equals("station3"))
            {
                GetWeatherTiles(codeFilePaths[0]);
                GetForecastTiles(codeFilePaths[1]);
            }
            else if (station.Equals("station7"))
            {
                GetWeatherTiles(codeFilePaths[2]);
                GetForecastTiles(codeFilePaths[3]);
            }
            else if (station.Equals("example"))
            {
                GetWeatherTiles("AviationCodeExample.txt");
                GetForecastTiles("ForecastExample.txt");
            }
        }

        private void GetWeatherTiles(string path)
        {
            MyWeatherTiles.Clear();
            var fileData = FileReader.ReadAvationFile(path);

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

        private void GetForecastTiles(string path)
        {
            MyFocastTiles.Clear();
            var fileData = FileReader.ReadForecastFile(path);

            if (fileData != null && fileData.Count > 0)
            {
                foreach (var listOfItems in fileData)
                {
                    ForecastTile tile = new(listOfItems);
                    MyFocastTiles.Add(tile);
                }
            }
        }
    }
}
