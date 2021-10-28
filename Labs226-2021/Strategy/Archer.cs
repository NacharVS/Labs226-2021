using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Archer : Unit
    {
        public Archer(string type, int mindamage, int maxdamage, int minshoot, int maxshoot, int speed, int minhp, int maxhp, int aspeed, int arr)
        {
            base.TypeUnit = type;
            base.Mindamage = mindamage;
            base.Maxdamage = maxdamage;
            base.Minshoot = minshoot;
            base.Maxshoot = maxshoot;
            base.Speed = speed;
            base.Minhealth = minhp;
            base.Maxhealth = maxhp;
            base.AttackSpeed = aspeed;
            base.Arrows = arr;
        }

        public void Shooting()
        {
            while (Arrows != 0)
            {
                int shoot = new Random().Next(Minshoot, Maxshoot);
                Console.WriteLine($"{TypeUnit} is shooting and diliverd {shoot} damage");
                Arrows = Arrows - 1;
            }
            if (Arrows == 0)
            {
                Console.WriteLine($"{TypeUnit} arows is over. Melee attacking ");
            }

        }
    }
}
