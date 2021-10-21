using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Peasant : Unit
    {
        public Peasant(string type,int mindamage, int maxdamage, int speed, int minhp, int maxhp, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.minhealth = minhp;
            base.maxhealth = maxhp;
            base.attackSpeed = aspeed;
        }

        public void Produce()
        {
            Console.WriteLine($"{typeUnit} is mining...");
            Console.WriteLine();
    }
    }
}
