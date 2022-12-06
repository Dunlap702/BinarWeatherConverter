﻿using BinarWeatherConverter.Models;
using BinarWeatherConverter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BinarWeatherConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm;

        public MainWindow()
        {
            InitializeComponent();
            if (DataContext is MainViewModel view)
            {
                mvm = view;
                view.ReadFile();
                mvm.GetTiles("example");
            }
        }

        private void menuStation3_Click(object sender, RoutedEventArgs e)
        {
            mvm.GetTiles("station3");
            
        }

        private void menuStation7_Click(object sender, RoutedEventArgs e)
        {
            mvm.GetTiles("station7");
        }

        private void menuExample_Click(object sender, RoutedEventArgs e)
        {
            mvm.GetTiles("example");
        }
    }
}
