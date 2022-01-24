using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Unit
    {

        public string type;
        public int health;
        public int maxHealth;
       
        public Unit(string type, int health)
        {
            this.type = type;
            this.health = health;
            this.maxHealth = health;
        }

        public void Creation()
        {
            System.Console.WriteLine($"{type} is created");
        }
        public void Termination()
        {
            System.Console.WriteLine($"{type} is terminated");
        }

        public void UnitInfo()
        {
            System.Console.WriteLine($"Unit: {type}. Health: {health}.");
        }
        public virtual void Info()
        {
            Console.WriteLine($"type - {type}health - {health} maxHealth - {maxHealth}");
        }
    }
}
