using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Archer : Unit
    {

        public static int arrows()
        {
            int arrow = new Random().Next(1, 11);
            return arrow;

        }
        public Archer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, string located, int arrows)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.health = hp;
            base.attackSpeed = aspeed;
            base.located = located;
        }

        public void Produce()
        {
            Console.WriteLine($"{typeUnit} is shoots...");
        }

        public void CancelAction()
        {
            Console.WriteLine($"{typeUnit} finished shoots...");
        }
    }
}
