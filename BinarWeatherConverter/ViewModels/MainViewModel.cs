using BinarWeatherConverter.Models;
using System.Collections.ObjectModel;

namespace BinarWeatherConverter.ViewModels
{
    public class MainViewModel
    {

        public ObservableCollection<WeatherTile> MyWeatherTiles { get; } = new();
        public ObservableCollection<ForecastTile> MyFocastTiles { get; } = new();

        public string avationFile = "code4.txt";
        public string forecastFile = "forecast.txt";

        public void ReadFile()
        {
            var fileData = FileReader.ReadAvationFile(avationFile);
            var fileData2 = FileReader.ReadForecastFile(forecastFile);

            if (fileData != null && fileData.Count > 0)
            {
                for (int i = 0; i < fileData.Count; i++)
                {
                    string[]? lineOfSplitData = fileData[i];

                    WeatherTile tile = new(lineOfSplitData);
                    MyWeatherTiles.Add(tile);
                }
            }
            if (fileData2 != null && fileData2.Count > 0)
            {
                foreach (var listOfItems in fileData2)
                {
                    ForecastTile tile = new(listOfItems);
                    MyFocastTiles.Add(tile);
                }

            }
        }
    }
}
