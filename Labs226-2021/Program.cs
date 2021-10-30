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
          
            Warrior Warrior1 = new Warrior();
            Warrior Warrior2 = new Warrior();
            Warrior2.Name = "Alalp"; Warrior1.Name = "Lokit";

            Warrior2.MinDamage = 15; Warrior1.MinDamage = 15; Warrior2.Health = 50;
            Warrior2.MaxDamage = 20; Warrior1.MaxDamage = 20; Warrior1.Health = 50;

            while (Warrior2.Health != 0 && Warrior1.Health != 0)
            {
                Actions.WarriorVSArcher(Warrior2, Warrior1);
            }


        }
       

    }
    }

