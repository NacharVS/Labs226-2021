using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Healer : Unit
    {
        public Healer(string type, int mindamage, int maxdamage, int speed, int minhp, int maxhp, int aspeed, int minheal, int maxheal)
        {
            base.TypeUnit = type;
            base.Mindamage = mindamage;
            base.Maxdamage = maxdamage;
            base.Speed = speed;
            base.Minhealth = minhp;
            base.Maxhealth = maxhp;
            base.AttackSpeed = aspeed;
            base.Minheal = minheal;
            base.Maxheal = maxheal;
        }
        public void Healing()
        {
            int heal = new Random().Next(Minheal, Maxheal);
            Console.WriteLine($"{TypeUnit} delivered {heal} heal for " + $"{TypeUnit}" + $" {Hp += heal} healthpoint");
            Hpp += heal;
            Console.WriteLine($"Current healthpoint {Hpp}");
            Console.WriteLine();
        }
    }
}