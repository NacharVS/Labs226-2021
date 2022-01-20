using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Healer : Unit
    {
        public Healer(string type, int health) : base(type, health)
        {

        }

        public void Healing()
        {
            Console.WriteLine($"{type}"); 
        }

    }
}
