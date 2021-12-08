using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Activate : Unit
    {
        public static void Activ()
        {

            Warrior war1 = new Warrior(30, 20, 10, 25);
            Mage mag1 = new Mage(15, 20, 35, 15);
            Rogue rog1 = new Rogue(20, 30, 15, 20);

            rog1.ShowInfo();
            rog1.Dex = 40;
            rog1.ShowInfo();


        }
    }
}