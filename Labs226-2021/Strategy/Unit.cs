using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Unit
    {
        public string typeUnit;
        public int minhealth;
        public int maxhealth;
        public int mindamage;
        public int maxdamage;
        public int speed;
        public int attackSpeed;
        public int minheal;
        public int maxheal;
        public int hp;
        public int arrows;


        public void currenthp()
        {
            
            hp = new Random().Next(minhealth, maxhealth);
            Console.WriteLine($"{typeUnit} current {hp} healpoint");
        }

        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{typeUnit} delivered {hit} damage");
        }
    }
}
