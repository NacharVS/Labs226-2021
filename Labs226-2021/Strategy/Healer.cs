using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Healer : Unit
    {
        public Healer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, int minheal, int maxheal)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.health = hp;
            base.attackSpeed = aspeed;
            base.minheal = minheal;
            base.maxheal = maxheal;
        }

        public void Healing()
        {
            Console.WriteLine($"{typeUnit} is healing");
        }
    }
}
