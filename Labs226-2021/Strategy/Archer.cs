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
            base.health = hp;
            base.attackSpeed = aspeed;
        }

        public void Shooting()
        {
            Console.WriteLine($"{typeUnit} is shooting");
        }
    }
}
