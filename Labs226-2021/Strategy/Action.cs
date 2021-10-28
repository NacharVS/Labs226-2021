using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labs226_2021.Strategy
{
    class Action: Unit
    {
        public static void Battle(Unit unit1, Unit unit2)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"unit {} hited unit {}");
            unit2.Attack(unit1.Inflictdamage());
        }
    }
}
