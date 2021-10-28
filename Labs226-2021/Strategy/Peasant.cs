using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Peasant : Unit
    {
        public Peasant(string type, int mindamage, int maxdamage, int speed, int minhp, int maxhp, int aspeed)
        {
            base.TypeUnit = type;
            base.Mindamage = mindamage;
            base.Maxdamage = maxdamage;
            base.Speed = speed;
            base.Minhealth = minhp;
            base.Maxhealth = maxhp;
            base.AttackSpeed = aspeed;
        }

        public void Produce()
        {
            Storage = 0;
            Console.WriteLine($"{TypeUnit} is mining...");
            while (Storage <= 64)
            {
                int mining = new Random().Next(2, 7);
                Storage += mining;
                Console.WriteLine($"{mining} coal");
            }
            Console.WriteLine("storage is full");
            Console.WriteLine();
        }
    }
}
