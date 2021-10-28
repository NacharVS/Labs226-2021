using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Archer : Unit
    {


        public Archer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, string located, int arrows)
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
            Console.WriteLine($"Archer выпускает стрелы...");
        }



        public void CancelAction()
        {
            Console.WriteLine($"Archer закончились стрелы");
        }
    }
}
