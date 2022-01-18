using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Peasant : Moveble
    {
        public int carryWeight;
        public Peasant() : base("Peasant", 30, 4 , 1)
        {
            carryWeight = 20;
        }

    }
}
