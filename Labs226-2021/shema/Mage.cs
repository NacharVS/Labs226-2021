using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Mage : Moveble
    {
        public Mage() : base("Mage", 20, 4, 5)
        {

        }
        public void spellcast()
        {
            Console.WriteLine($"Mage is casting spell and deal damage {damage} to something ");
        }
    }
}
