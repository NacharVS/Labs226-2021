using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class ArcherTower : Building
    {
        public ArcherTower(string type, int health) : base("ArcherTower", 100, 75)
        {
        }
        public void LoadArchers() 
        {
            Console.WriteLine($"Archers are loaded");
        }
    }
}
