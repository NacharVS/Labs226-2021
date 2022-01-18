using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Building : Unit
    {
        public int PhysicalResist;
        public Building(string type, int health) : base(type, health)
        {

        }
    }
}
