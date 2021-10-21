using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Archer : Unit
    {
        public Archer(string type, int mindamage, int maxdamage, int speed, int minhp, int maxhp, int aspeed, int arr)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.minhealth = minhp;
            base.maxhealth = maxhp;
            base.attackSpeed = aspeed;
            base.arrows = arr;
        }

        public void Shooting()
        {
            if (arrows != 0)
            { 
                Console.WriteLine($"{typeUnit} is shooting");
                arrows = arrows - 1;
                Console.WriteLine();
            }
            else
            {
                
            }
    }
    }
}
