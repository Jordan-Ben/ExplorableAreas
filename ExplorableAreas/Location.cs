using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorableAreas
{
    class Location
    {
        public string Name;
        public string Description;
        public string LocationPath = "";

        public List<Player> People = new List<Player>();


        public Location() { }
        public Location(string name, string description)
        {
            Name = name;
            Description = description;

            People.Add(new Player("Todd", "Todd :( "));
        
        }

    }
}
