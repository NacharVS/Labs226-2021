using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {


            Peasant peasant1 = new Peasant("peasant1", 1, 6, 3, 30, 3, "Bridge");
            peasant1.Attack();
            peasant1.Produce();
            peasant1.CancelAction();
            peasant1.Moving();
            peasant1.HoldPositon();
            peasant1.Death();
            Console.WriteLine();

            Healer healer1  = new Healer("healer1", 1, 6, 3, 50, 3, "hospital");
            healer1.Attack();
            healer1.Produce();
            healer1.CancelAction();
            healer1.Moving();
            healer1.HoldPositon();
            healer1.Death();

        }
    }
}
