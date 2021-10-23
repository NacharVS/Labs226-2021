using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Healer : Unit
    {
        public Healer(string type, int mindamage, int maxdamage, int speed, int maxhealth, int minhealth, int minheal, int maxheal, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.minhealth = minhealth;
            base.maxhealth = maxhealth;
            base.minheal = minheal;
            base.maxheal = maxheal;
            base.attackSpeed = aspeed;
        }
        public void Healing()
        {
            for (int i = maxhealth; i > hp; i += 0)
            {
                int heal = new Random().Next(minheal, maxheal);
                Console.WriteLine($"{typeUnit} вылечил {heal} очков здороьвя." + $"{typeUnit}" + $" {hp + heal} healthpoint");
                Console.Write($"{typeUnit} теперь имеет {hp + heal} очков здороьвя.");
                Console.WriteLine();
            }
        }
    }
}