using System;
using System.Collections.Generic;
using System.Text;
using Labs226_2021.Strategy;

namespace Labs226_2021
{
    class Task
    {
        static void Main ()
        {
          
            Warrior WarriorArcher = new Warrior();
            Warrior Warrior = new Warrior();
            WarriorArcher.Name = "Archer"; Warrior.Name = "Warior";

            WarriorArcher.MinDamage = 15; Warrior.MinDamage = 15; WarriorArcher.Health = 50;
            WarriorArcher.MaxDamage = 20; Warrior.MaxDamage = 20; Warrior.Health = 50;

            while (WarriorArcher.Health != 0 && Warrior.Health != 0)
            {
                Actions.WarriorVSArcher(WarriorArcher, Warrior);
            }


        }
       

    }
    }

