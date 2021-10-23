using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Healer : Unit
    {
        public Healer(string type, int mindamage, int maxdamage, int speed, int minhp, int maxhp, int aspeed, int minheal, int maxheal)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.minhealth = minhp;
            base.maxhealth = maxhp;
            base.attackSpeed = aspeed;
            base.minheal = minheal;
            base.maxheal = maxheal;
        }
        public void Healing()
        {
            int heal = new Random().Next(minheal, maxheal);
            Console.WriteLine($"{typeUnit} delivered {heal} heal for " + $"{typeUnit}"+ $" {hp += heal} healthpoint");
            hpp += heal;
            Console.WriteLine($"Current healthpoint {hpp}");
            Console.WriteLine();
        }
    }
}
