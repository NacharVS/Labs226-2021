using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Activate
    {
        public static void Activ()
        {
            Mage mag = new Mage();
            Warrior war = new Warrior();
            Archer rog = new Archer();

            mag.Name = "Геральт";
            mag.Str = 40;
            mag.Dex = 15;
            mag.Con = 15;
            mag.Intl = 10;

            war.Name = "Кратос";
            war.Str = 30;
            war.Dex = 15;
            war.Con = 15;
            war.Intl = 10;

            rog.Name = "Леголас";
            rog.Str = 50;
            rog.Dex = 15;
            rog.Con = 15;
            rog.Intl = 10;


            Unit[] array = new Unit[3] { war, mag, rog };

            for (int i = 0; i < array.Length; i++)
            {

                array[i].PAttack = 0;
                array[i].MAttack = 0;
                array[i].PDefence = 0;
                array[i].MDefence = 0;
                array[i].Mana = 0;
                array[i].PAttack = 0;
            }

            mag.Health = 0;
            war.Health = 0;
            rog.Health = 0;

            war.ShowInfo();
            Console.WriteLine("__________________");
            Console.WriteLine();
            mag.ShowInfo();
            Console.WriteLine("__________________");
            Console.WriteLine();
            rog.ShowInfo();
            Console.WriteLine("__________________");

            Console.WriteLine();
            Battle.Battle1(war, rog);








        }
    }
}