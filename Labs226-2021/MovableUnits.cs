using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    class MovableUnits : Unit
    {
        public int walkingSpeed;
        public MovableUnits(string type, int health, int walkingSpeedParam) : base(type, health)
        {
            walkingSpeed = walkingSpeedParam;
        }

        public void Moving()
        {
            Console.WriteLine($"{type} is moving");
        }
    }
}
