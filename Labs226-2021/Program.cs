using Labs226_2021.Interfaces;
using Labs226_2021.Shop;
using Labs226_2021.Strategy;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Andrey = new Warrior(new Club(), new ShortBow());
            Blacksmith Kuzma = new Blacksmith();
            Andrey.Attack();
            var weapon2 = Kuzma.CraftStoneAxe();
            Andrey.ChangeWeapon(weapon2);
            Andrey.Attack();
            var weapon3 = Kuzma.CraftIronSword();
            Andrey.ChangeWeapon(weapon3);
            Andrey.Attack();
            Console.WriteLine(weapon3.durability);
            Kuzma.RepairItem(weapon3);
            Console.WriteLine(weapon3.durability);
            Kuzma.RepairItem(weapon3);
            Console.WriteLine(weapon3.durability);
            Kuzma.RepairItem(weapon2);
            Console.WriteLine(weapon2.durability);




        }


    }
}
