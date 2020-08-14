using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorableAreas
{
    class Player
    { 
       public string Name;
      public string Description;

        public List<Item> Inventory = new List<Item>();
      
        public Player (string name, string description)
        { Name = name;
          Description = description;

        }
        public Player() { }
    }
}
