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
        public void work()
        {
            Console.WriteLine($"Peasant is working..");
            Console.WriteLine($"Peasant is working...");
            Console.WriteLine($"Peasant is working.....");
            Console.WriteLine($"Peasant is full");
            carryWeight = 0;
        }
        public override void Info()
        {
            Console.WriteLine($"type - {type}health - {health} maxHealth - {maxHealth} walkingSpeed - {walkingSpeed} damage - {damage} carryWeight - {carryWeight}");
        }
    }
}
