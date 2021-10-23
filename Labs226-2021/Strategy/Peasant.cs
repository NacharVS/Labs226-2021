using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Peasant: Unit
    {
        public Peasant(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, string located)
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
            Console.WriteLine($"Peasant добывает ресурсы...");
        }

        public void CancelAction()
        {
            Console.WriteLine($"Peasant закончил добывать ресурсы в шахте...");
        }
    }
}
