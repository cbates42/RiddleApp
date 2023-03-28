using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleApp
{
    public class Item
    {

        public Item(string name)
        {
            Name = name;
    
        }

        public string Name { get; set; } = "";

        public Item randomItem(int randomizer)
        {
            switch(randomizer)
            {
                default: return new Item("Sword of Default");
                case 1: return new Item("Sword of Chaos");
                case 2: return new Item("Potion of Healing");
                case 3: return new Item("Gold a'Plenty");
                case 4: return new Item("Paradox Sword");
                case 5: return new Item("Potion of Death");
                case 6: return new Item("More Gold");
       
            } 
        }

    }
}
