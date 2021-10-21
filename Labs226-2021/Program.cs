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
            Peasant peasant1 = new Peasant("peasant1", 1, 6, 3, 0, 30, 3);
            peasant1.currenthp();
            peasant1.Attack();
            peasant1.Produce();
            Archer archer1 = new Archer("archer1", 3, 9, 4, 0, 30, 3, 2);
            archer1.currenthp();
            archer1.Attack();
            archer1.Shooting();
            Healer healer1 = new Healer("healer1", 0, 1, 2, 0, 20, 2, 6, 10);
            healer1.currenthp();
            healer1.Attack();
            healer1.Healing();
        }
    }
}
