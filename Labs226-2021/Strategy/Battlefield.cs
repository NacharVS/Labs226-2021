using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
   

    class Actions : Unit
    
    {
        public static void WarriorVSArcher(Unit Warrior1, Unit Warrior2)
        {
            Console.WriteLine($"Battle {Warrior1.Name} and  {Warrior2.Name}");
            
            Console.WriteLine();
            if (Warrior1.Health > 0)
            {
<<<<<<< HEAD
                Console.WriteLine($"{WarriorArcher.Name} deliveri damage {Warrior.Name}у");
                Warrior.GetDamage(WarriorArcher.InflictDamage()); 
            } 
            if (Warrior.Health > 0)
=======
                Console.WriteLine($"{Warrior1.Name} delivere damage {Warrior2.Name}у");
                Warrior2.GetDamage(Warrior1.InflictDamage());
            }
            if (Warrior2.Health > 0)
>>>>>>> 7dc46896327904c8f11eb3eca1b17fb64a241b66
            {
                Console.WriteLine($"{Warrior2.Name}  delivere damage  {Warrior1.Name}у");
                Warrior1.GetDamage(Warrior2.InflictDamage()); 
            }

            Console.WriteLine();

            if (Warrior2.Health > 0)
            {
                Console.WriteLine($"{Warrior2.Name} - {Warrior2.Health} Hp");
            }
            if (Warrior1.Health > 0)
            {
                Console.WriteLine($"{Warrior1.Name} - {Warrior1.Health} Hp");
            }
        }


    }
}
