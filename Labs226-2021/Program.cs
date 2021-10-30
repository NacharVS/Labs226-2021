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
            Mage Warrior2 = new Mage();
            Warrior2.Name = "Alalp"; Warrior1.Name = "Lokit";

            Warrior2.MinDamage = 5; Warrior1.MinDamage = 5; Warrior2.Health = 50;
            Warrior2.MaxDamage = 7; Warrior1.MaxDamage = 9; Warrior1.Health = 50;
           

            while (Warrior2.Health != 0 && Warrior1.Health != 0)
            {
                Actions.WarriorVSArcher(Warrior1, Warrior2);
            }


        }
       

    }
    }

