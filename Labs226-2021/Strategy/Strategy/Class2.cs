using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Archer : Unit
    {
        public Archer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.maxhealth = hp;
            base.attackSpeed = aspeed;
        }

        public void Produce()
        {
            Console.WriteLine($"{typeUnit} is mining...");
        }
    }
}