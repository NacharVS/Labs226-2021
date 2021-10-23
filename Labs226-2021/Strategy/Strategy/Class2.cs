using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Archer : Unit
    {
        public Archer(string type, int mindamage, int maxdamage, int minArcherdamage, int maxArcherdamage, int speed, int maxhealth, int minhealth, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.minArcherdamage = minArcherdamage;
            base.maxArcherdamage = maxArcherdamage;
            base.speed = speed;
            base.minhealth = minhealth;
            base.maxhealth = maxhealth;
            base.attackSpeed = aspeed;
        }
    }
}