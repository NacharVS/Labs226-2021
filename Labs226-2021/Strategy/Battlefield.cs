using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Battlefield : Unit
    {
        public static void Battle(Unit unit, Unit unit2)
        {
            Console.WriteLine($"unit {unit.TypeUnit} hited unit {unit2.TypeUnit} ");
            Console.WriteLine($"unit {unit2.TypeUnit} get {unit.Hit}");
            Console.WriteLine($"unit {unit2.TypeUnit} hited unit {unit.TypeUnit} ");
            Console.WriteLine($"unit {unit.TypeUnit} get {unit2.Hit}");
            Console.WriteLine($"{unit2.TypeUnit} - {unit2.Hpp}");
            Console.WriteLine($"{unit.TypeUnit} - {unit.Hpp}");
        }
    }
}
