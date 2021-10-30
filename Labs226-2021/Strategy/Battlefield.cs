using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
   

    class Actions : Unit
    
    {
        public static void WarriorVSArcher(Unit WarriorArcher, Unit Warrior)
        {
            Console.WriteLine($"Battle {WarriorArcher.Name} and  {Warrior.Name}");
            
            Console.WriteLine();
            if (WarriorArcher.Health > 0)
            {
                Console.WriteLine($"{WarriorArcher.Name} delivere damage {Warrior.Name}у");
                Warrior.GetDamage(WarriorArcher.InflictDamage());
            }
            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name}  delivere damage  {WarriorArcher.Name}у");
                WarriorArcher.GetDamage(Warrior.InflictDamage());
            }

            Console.WriteLine();

            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name} - {Warrior.Health} Hp");
            }
            if (WarriorArcher.Health > 0)
            {
                Console.WriteLine($"{WarriorArcher.Name} - {WarriorArcher.Health} Hp");
            }
        }


    }
}
