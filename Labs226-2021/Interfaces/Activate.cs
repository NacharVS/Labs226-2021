using System;
using Labs226_2021.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class Activate
    {
        public static void Activ()
        {
            Warrior Andrey = new Warrior(new Club(), new ShortBow());
            Blacksmith Kuzma = new Blacksmith();
            Andrey.Attack();
            Andrey.Attack();

            var weapon3 = Kuzma.CraftIronSword();
            Andrey.ChangeMleeWeapon(weapon3);

            Andrey.Attack();

            Console.WriteLine(weapon3.durability);
            Kuzma.RepairItem(weapon3);
            Console.WriteLine(weapon3.durability);
            Kuzma.RepairItem(weapon3);
            Console.WriteLine(weapon3.durability);

        }
    }
}
