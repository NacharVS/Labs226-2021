using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class ArcherTower : Building
    {
     
        public ArcherTower(string type, int health, int NowInTowerParam) : base("ArcherTower", 100, 75, 0, 5)
        {
            NowInBuilding = NowInTowerParam;
        }
        public void showinfo() 
        {
            Console.WriteLine($"сейчас в башне {NowInBuilding} лучников");
            if (NowInBuilding > 0)
            {
                Console.WriteLine($"Башня стреляет и наносит {NowInBuilding * 2} урона");
            }
            else 
            {
                Console.WriteLine($"Башня не стреляет ");
            }
        }
        public void LoadArchers(int counter) 
        {
            if (NowInBuilding <= Maxunits && NowInBuilding + counter <= Maxunits)
            {
                NowInBuilding += counter;
            }
            else
            if (NowInBuilding != Maxunits)
            {
                NowInBuilding = Maxunits;

            }
            else
            {
                Console.WriteLine("Башня полная");
            }
        }
    }
}
