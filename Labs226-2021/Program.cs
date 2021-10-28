using System;
using System.Collections.Generic;
using System.Text;
using Labs226_2021.Strategy;

namespace Labs226_2021
{
    class Task
    {
        static void Main ()
        {
            //Peasant peasant1 = new Peasant("peasant1", 1, 6, 3, 1, 30, 3);
            //peasant1.title();
            //peasant1.currenthp();
            //peasant1.Produce();
            //peasant1.Attack();
            //Archer archer1 = new Archer("archer1", 1, 2, 4, 8, 4, 1, 30, 3, 2);
            //archer1.currenthp();
            //archer1.Shooting();
            //archer1.Attack();
            //Console.WriteLine();
            //Healer healer1 = new Healer("healer1", 0, 1, 2, 1, 20, 2, 6, 10);
            //healer1.currenthp();
            //healer1.Attack();
            //healer1.Healing();
            //Mage mage1 = new Mage("mage1", 2, 1, 15, 2, 100, 20, 15, 10);
            //mage1.currenthp();
            //mage1.Spell();
            //peasant1.credits();
            Peasant peasant1 = new Peasant("peasant1", 1, 6, 3, 1, 30, 3);
            Archer archer1 = new Archer("archer1", 1, 2, 4, 8, 4, 1, 30, 3, 2);
            while (peasant1.Hpp !=0 || archer1.Hpp !=0) 
            {
              Battlefield.Battle(peasant1, archer1);
            }
        }
    }
}
