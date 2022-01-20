using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Barrack : Building
    {
        public Barrack(string type, int health) : base("Barrack", 75 , 50, 0, 15)
        {
        }
        public void training(Archer count)
        {
            Console.WriteLine($"Barrack is training {count}");

        }
    }
}
