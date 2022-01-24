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
        public void Creating()
        {
            System.Console.WriteLine($"Вы создали{type}");
        }
        public void UnitInfo()
        {
            System.Console.WriteLine($"Юнит: {type}. Здоровье: {health}.");
        }
        public virtual void Info()
        {
            Console.WriteLine($"Тип - {type}здоровье - {health} Максимальное здороье - {maxHealth}");
        }
        public void Termination()
        {
            System.Console.WriteLine($"{type} был(-а) уничтожен(-а)");
        }
    }
}
