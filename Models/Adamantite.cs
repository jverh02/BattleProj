using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class Adamantite : IArmor
    {
        public string Name { get; set; }
        public int Defense { get; set; }

        // default constructor
        public Adamantite()
        {
            Name = "Adamantite Armor";
            Defense = 25;
        }
        // constructor
        public Adamantite(string name, int defense)
        {
            Name = name;
            Defense = defense;
        }

    }
}
