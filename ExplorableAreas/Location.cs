using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace ExplorableAreas
{
    class Location
    {
        public string Name;
        public string Description;
        public string LocationPath = "Images/Forest.bmp";

        public List<Player> People = new List<Player>();


        public Location() { }
        public Location(string name, string description)
        {
            Name = name;
            Description = description;

            People.Add(new Player("Todd", "Todd :( "));
        
        }
        public BitmapImage ShowLocationImage ()
        {
            return new BitmapImage(new Uri(LocationPath, UriKind.Relative));
        }

    }
}
