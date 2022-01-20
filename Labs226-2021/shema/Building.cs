using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Building : Unit
    {
        public int PhysicalResist;
        public int NowInBuilding;
        public int Maxunits;
        public Building(string type, int health , int  PhysicalResistParam, int NowInBuildingParam, int MaxunitsParam) : base(type, health)
        {
            PhysicalResist = PhysicalResistParam;
            NowInBuilding = NowInBuildingParam;
            Maxunits = MaxunitsParam;
        }
        public override void Info()
        {
            Console.WriteLine($"type - {type}health - {health} maxHealth - {maxHealth} PhysicalResist - {PhysicalResist}");
        }
    }
}
