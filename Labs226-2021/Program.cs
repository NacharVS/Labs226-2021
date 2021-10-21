using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Peasant peasant1 = new Peasant("peasant1", 1, 6, 3, 30, 3);
            peasant1.Attack();
            peasant1.Produce();
        }
    }
}
