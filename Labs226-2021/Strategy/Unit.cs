using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Unit
    {
        public string typeUnit;
        public int health;
        public int mindamage;
        public int maxdamage;
        public int speed;
        public int attackSpeed;

        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{typeUnit} delivered {hit} damage");
        }
        
    }
}
