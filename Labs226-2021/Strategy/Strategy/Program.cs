using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Unit
    {
        public string typeUnit;
        public int maxhealth;
        public int minhealth;
        public int mindamage;
        public int maxdamage;
        public int speed;
        public int attackSpeed;

        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{typeUnit} нанёс {hit} урона");
        }
        public void Death()
        {
            int health = maxhealth;
            if (health == 0)
                Console.WriteLine($"{typeUnit} слегка умер");
        }
    }
}
