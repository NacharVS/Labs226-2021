using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Moveble: Unit
    {
        public int walkingSpeed;
        public int damage;
        public Moveble (string type, int health, int walkingSpeedParam , int damageParam) : base(type, health)
        {
            walkingSpeed = walkingSpeedParam;
            damage = damageParam;
        }
        public void Atack()
        {
            Console.WriteLine($"{type} dealt damage {damage} to someone");
        }
        public void Moving()
        {
            Console.WriteLine($"{type} is moving");
        }
    }
}
