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
        public string located; 
        
       
        

        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{typeUnit} нанёс {hit} урона");
        }

        public void Moving()
        {
            int walking = speed;
            Console.WriteLine($"{typeUnit} runs at a speed of {walking}");
        }

        public void HoldPositon()
        {
            string position = located;
            Console.WriteLine($"{typeUnit} stands on {position} ");
        }

        public void Death()
        {
            if (health == 0)
            {
                Console.WriteLine($"{typeUnit} died");
            }
        }

    }
}
