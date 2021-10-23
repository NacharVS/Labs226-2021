using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Archer : Unit
    {
        public Archer(string type, int mindamage, int maxdamage, int minshoot, int maxshoot, int speed, int minhp, int maxhp, int aspeed, int arr)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.minshoot = minshoot;
            base.maxshoot = maxshoot;
            base.speed = speed;
            base.minhealth = minhp;
            base.maxhealth = maxhp;
            base.attackSpeed = aspeed;
            base.arrows = arr;
        }

        public void Shooting()
        {
            while (arrows != 0)
            {
                int shoot = new Random().Next(minshoot, maxshoot);
                Console.WriteLine($"{typeUnit} is shooting and diliverd {shoot} damage");
                arrows = arrows - 1;
            }

        }
    }
}
