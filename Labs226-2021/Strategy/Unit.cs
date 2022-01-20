using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
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
            Console.WriteLine($"{type} is created");
        }
        public void Termination()
        {
            Console.WriteLine($"{type} is terminated");
        }

        public void UnitInfo()
        {
            Console.WriteLine($"Unit: {type}. Health: {health}.");
        }
    }
}