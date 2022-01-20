using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Archer : Moveble
    {
        public Archer() : base("Archer", 20, 7, 2)
        {
        }
        public void Shooting()
        {
            Console.WriteLine($"Archer is shooting and delivery damage {damage} to someone ");
        }
    }
}
