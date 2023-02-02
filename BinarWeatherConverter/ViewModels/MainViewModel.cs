using BinarWeatherConverter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace BinarWeatherConverter.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public enum LocationType
        {
            Station3,
            Station7,
            [Description("This uses a local example that I made")]
            Example
        }
         
        private FileWatcher watcher;
        private DateTime lastUpdated;

        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value; OnPropertyChanged(nameof(LastUpdated)); }
        }
        public MainViewModel()
        {
            CommandRefresh = new Commands.Command(Refresh);

            watcher = new(this);
            watcher.FileWatcherEvent += Watcher_FileWatcherEvent;
        }

        private void Watcher_FileWatcherEvent(object? sender, EventArgs e)
        {
            System.Windows.Threading.Dispatcher dp = App.Current.Dispatcher;
            if (dp.CheckAccess())
                Refresh();
            else
            {
                //Continue to invoke it until we find it
                dp.Invoke(() => Watcher_FileWatcherEvent(sender, e));
            }
        }

        public LocationType SelectedLocation
        {
            get => selectedLocation;
            set
            {
                selectedLocation = value;
                OnPropertyChanged(nameof(SelectedLocation));
            }
        }

        public ObservableCollection<WeatherTile> MyWeatherTiles { get; } = new();
        public ObservableCollection<ForecastTile> MyFocastTiles { get; } = new();

        public ICommand CommandRefresh { get; set; }
        public List<string> codeFilePaths = new();
        private LocationType selectedLocation;
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
            LastUpdated = DateTime.Now;

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
            SelectedLocation = type;
            Settings1.Default.LastViewedStation = ((int)type).ToString();
        }

        private void GetWeatherTiles(string path)
        {
            MyWeatherTiles.Clear();
            var fileData = FileReader.ReadAvationFile(path);
            watcher.Watch(path);

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

        internal void Refresh()
        {
            GetTiles(SelectedLocation);
        }
    }
}
