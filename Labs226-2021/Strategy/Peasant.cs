using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Peasant : Unit
    {


        public Peasant(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, string located)
        {
            base.TypeUnit = type;
            base.Mindamage = mindamage;
            base.Maxdamage = maxdamage;
            base.Speed = speed;
            base.CurrentHealth = hp;
            base.AttackSpeed = aspeed;
            base.Located = located;


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
