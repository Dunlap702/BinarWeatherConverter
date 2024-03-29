﻿using BinarWeatherConverter.ViewModels;
using System;
using System.Windows;

namespace BinarWeatherConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel? mvm;

        public MainWindow()
        {
            InitializeComponent();
            mvm = DataContext as MainViewModel;

            mvm?.ReadFile();

            MainViewModel.LocationType location;
            location = (MainViewModel.LocationType)Enum.Parse(typeof(MainViewModel.LocationType),
                        Settings1.Default.LastViewedStation);

            mvm?.GetTiles(location);
        }

        private void menuStation3_Click(object sender, RoutedEventArgs e)
        {
            mvm?.GetTiles(MainViewModel.LocationType.Station3);

        }

        private void menuStation7_Click(object sender, RoutedEventArgs e)
        {
            mvm?.GetTiles(MainViewModel.LocationType.Station7);
        }

        private void menuExample_Click(object sender, RoutedEventArgs e)
        {
            mvm?.GetTiles(MainViewModel.LocationType.Example);
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            Settings1.Default.Save();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.F5)
                mvm?.Refresh();
        }
    }
}
