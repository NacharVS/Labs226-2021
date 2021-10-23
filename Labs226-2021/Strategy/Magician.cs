using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Magician: Unit
    {
        public Magician(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, string located, int magicPoints )
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
            Console.WriteLine($"Magician");
        }


        public void CancelAction()
        {
            Console.WriteLine($"Magician");
        }

        
    }
}
