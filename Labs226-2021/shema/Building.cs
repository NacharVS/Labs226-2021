using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Building : Unit
    {
        public int PhysicalResist;
        public Building(string type, int health , int  PhysicalResistParam) : base(type, health)
        {
            PhysicalResist = PhysicalResistParam;
        }
        public override void Info()
        {
            Console.WriteLine($"type - {type}health - {health} maxHealth - {maxHealth} PhysicalResist - {PhysicalResist}");
        }
    }
}
