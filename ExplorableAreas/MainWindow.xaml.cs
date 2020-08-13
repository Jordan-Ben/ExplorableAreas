﻿using System;
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

namespace ExplorableAreas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Location> locations = new List<Location>();
        Location currentLocation = new Location();


        public MainWindow()
        {
            InitializeComponent();
        }
        private void Start()
        {
            SetUpLocation();
            ShowLocationsMenu();
            Travel();
        }

        //set up locations
        private void SetUpLocation()
        {
            locations.Add(new Location("loc a", "des a"));
            locations.Add(new Location("loc b", "des b"));
            locations.Add(new Location("loc c", "des c"));

            currentLocation = locations[0];
        }

        private void ShowLocationsMenu()
        {
            string temp = "";

            foreach(Location location in locations)
            {
                temp += location.Name + "\n";                
            }
            LocationMenu.Text = temp;
        }

        private void Travel()
        {
            LocationNameTextBlock.Text = currentLocation.Name;
            LocationDescriptionTextBlock.Text = currentLocation.Description;
        }

        private void TravelButton_Click(object sender, RoutedEventArgs e)
        {
            string location = TravelLocationTextBox.Text;
            location = location.ToLower();

            if(location != "")
            {
                foreach (Location l in locations)
                {
                    if(l.Name.ToLower().Contains(location))
                    {
                        currentLocation = l;
                        Travel();
   
                    }
                }
            }
        }
    }






}
