using BinarWeatherConverter.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BinarWeatherConverter.ViewModels
{
    public class MainViewModel
    {
        public enum LocationType
        {
            Station3,
            Station7,
            [Description("This uses a local example that I made")]
            Example
        }
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

        public void GetTiles(LocationType type = LocationType.Example)
        {
            if (type == LocationType.Station3)
            {
                GetWeatherTiles(codeFilePaths[0]);
                GetForecastTiles(codeFilePaths[1]);
            }
            else if (type == LocationType.Station7)
            {
                GetWeatherTiles(codeFilePaths[2]);
                GetForecastTiles(codeFilePaths[3]);
            }
            else if (type == LocationType.Example)
            {
                GetWeatherTiles("AviationCodeExample.txt");
                GetForecastTiles("ForecastExample.txt");
            }
            Settings1.Default.LastViewedStation = ((int)type).ToString();
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
