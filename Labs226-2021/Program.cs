using Labs226_2021.Strategy;
using System;
using System.Threading;
using Labs226_2021.Div;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
         Warior warior  = new Warior();
            warior.Con = 7100;
            warior.Dex = 80804;
            warior.Str = 5045;
            warior.Int = 1;
            warior.Damag = 0;
            warior.Mana = 0;
            warior.Healing = 0;
            warior.Defense = 0;
            warior.ShowInfo();
            warior.Attack();

        }
    }
}
