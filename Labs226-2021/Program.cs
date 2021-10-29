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

            Mage WarriorArcher = new Mage ();
            Healer Warrior = new Healer();
            WarriorArcher.Name = "Warrior"; Warrior.Name = "Warior";

                  Warrior.MinDamage = 15;                                                     WarriorArcher.Health = 50; 
            WarriorArcher.MaxDamage = 10; WarriorArcher.MinDamage = 7; Warrior.MaxDamage = 20; Warrior.Health = 50;
            Warrior.Healing = 45;
            while (WarriorArcher.Health != 0 && Warrior.Health != 0)
            {
                Actions.WarriorVSArcher(WarriorArcher, Warrior);
            }


        }
       

    }
    }

