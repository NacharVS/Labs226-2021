using Labs226_2021.Interfaces;

using Labs226_2021.Strategy;
using System;
using System.Collections.Generic;
using System.Threading;
 class Program
 {
    static void Main(string[] args)
    {
        Warrior Andruysha = new Warrior(new Club(), new Bow());
        Blacksmith Kuzya = new Blacksmith();
        Andruysha.Attack();
        var weapon2 = Kuzya.CraftStoneAxe();
        Andruysha.ChangeWeapon(weapon2);
        Andruysha.Attack();
        Kuzya.RepairItem(weapon2);
        var weapon3 = Kuzya.CraftIronSword();
        Andruysha.ChangeWeapon(weapon3);
        Andruysha.Attack();
        Console.WriteLine(weapon3.durability);
        Kuzya.RepairItem(weapon3);
        Console.WriteLine(weapon3.durability);
    }
}