﻿using Labs226_2021.Interfaces;
using Labs226_2021.Shop;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Andrey = new Warrior(new Club());
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
            var weapon4 = Kuzma.CraftShortBow();
            Andrey.ChangeWeapon(weapon4);
            Andrey.Attack();
            var weapon5 = Kuzma.CraftLightCrossbow();
            Andrey.ChangeWeapon(weapon5);
            Andrey.Attack();





        }

        //static void ShowMessage(double balance, double old, double diff)
        //{
        //    Console.WriteLine($"Balance has changed! Old Balance {old} Current balance {balance}. Difference {diff}");
        //}
    }
}
