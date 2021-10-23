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
        public int minshoot;
        public int maxshoot;
        public int speed;
        public int attackSpeed;
        public int minheal;
        public int maxheal;
        public int hp;
        public int arrows;
        public int fireball;
        public int staticstorm;
        public int frostbite;
        public int mp;
        public int currenthpp;
        public int hpp;


        public void currenthp()
        {
            hpp = 0;
            hp = new Random().Next(minhealth, maxhealth);
            Console.WriteLine($"{typeUnit} current {hpp += hp} healpoint");
        }

        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{typeUnit} delivered {hit} damage");
        }
    }
}
