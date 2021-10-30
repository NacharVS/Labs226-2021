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

            Peasant Warrior1 = new Peasant();
            Peasant Warrior2 = new Peasant();
            Warrior2.Name = "Alalp"; Warrior1.Name = "Lokit";

            Warrior2.MinDamage = 5; Warrior1.MinDamage = 5; Warrior2.Health = 150;
            Warrior2.MaxDamage = 7; Warrior1.MaxDamage = 9; Warrior1.Health = 150;

            while (Warrior2.Health != 0 && Warrior1.Health != 0)
            {
                Actions.WarriorVSArcher(Warrior2, Warrior1);
            }


        }
       

    }
    }

