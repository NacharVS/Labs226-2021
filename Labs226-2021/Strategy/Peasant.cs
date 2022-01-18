using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
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

