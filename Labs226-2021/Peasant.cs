using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    class Peasant : MovableUnits
    {
        public int carryWeight;
        public Peasant() : base("Peasant", 30, 4)
        {
            carryWeight = 20;
        }
    }
}
