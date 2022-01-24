using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class ArcherTower : Building
    {

        public ArcherTower(string type, int health, int NowInTowerParam ) : base("ArcherTower", 100, 75, 0, 5)
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
        public void LoadArchers(Archer archer)
        {

            Console.WriteLine($"{archer.type} загружен в башню");
            string a = "a";
            string b = "b";
            string c = "c";
            string d = "d";
            string f = "f";
            if (archer.type != a && archer.type != b && archer.type != c && archer.type != d && archer.type != d && archer.type != f)
            {
                

                if (a == "a")
                {
                    a = archer.type;
                    if (NowInBuilding + 1 != Maxunits)
                    {
                        NowInBuilding = NowInBuilding + 1;
                    }
                    else
                    {
                        Console.WriteLine("Башня фулл");
                    }

                }
                else if (b == "b")
                {
                    b = archer.type;
                    if (NowInBuilding + 1 != Maxunits)
                    {
                        NowInBuilding = NowInBuilding + 1;
                    }
                    else
                    {
                        Console.WriteLine("Башня фулл");
                    }

                }
                else if (c == "c")
                {
                    c = archer.type;
                    if (NowInBuilding + 1 != Maxunits)
                    {
                        NowInBuilding = NowInBuilding + 1;
                    }
                    else
                    {
                        Console.WriteLine("Башня фулл");
                    }

                }
                else if (d == "d")
                {
                
                    d = archer.type;
                    if (NowInBuilding + 1 != Maxunits)
                    {
                        NowInBuilding = NowInBuilding + 1;
                    }
                    else
                    {
                        Console.WriteLine("Башня фулл");
                    }

                }
                else if (f == "f")
                {
                    f = archer.type;
                    if (NowInBuilding + 1 != Maxunits)
                    {
                        NowInBuilding = NowInBuilding + 1;
                    }
                    else
                    {
                        Console.WriteLine("Башня фулл");
                    }

                }
                else
                {
                    Console.WriteLine("Этот арчер уже в башне");
                }
            }

               
        }
    }
}
