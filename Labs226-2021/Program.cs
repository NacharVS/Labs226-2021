using Labs226_2021.Div;
using System;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Warior warior = new Warior();
            Mage mag = new Mage();
            Rogur rogor = new Rogur();
            warior.Con = 7100;
            warior.Dex = 80804;
            warior.Str = 5045;
            warior.Int = 20;
          

            warior.ShowInfo();
            warior.AttackP();
            warior.Lvlup(10);
            warior.ShowInfo();
            warior.Lvlup(48);
            warior.ShowInfo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            mag.Con = 7100;
            mag.Dex = 80804;
            mag.Str = 5045;
            mag.Int = 1;
            mag.DamagM = 0;
            mag.Mana = 0;
            mag.Healing = 0;
            mag.DefenseM = 0;
            mag.Lvl = 0;
            rogor.Con = 7100;
            rogor.Dex = 80804;
            rogor.Str = 5045;
            rogor.Int = 100;
            rogor.DamagP = 0;
            rogor.Mana = 35;
            rogor.Healing = 0;
            rogor.DefenseP = 0;
            rogor.Lvl = 0;

            mag.ShowInfo();
            mag.AttackP();
            mag.Lvlup(30);
            mag.ShowInfo();
            mag.Lvlup(78);
            mag.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("___");
            Console.WriteLine();
            rogor.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("___");
            Console.WriteLine();

            rogor.Str = 1;
            rogor.Con = 1;
            rogor.Healing = 1;
            rogor.FallMan();
            rogor.FallHel();
            Console.WriteLine();
            Console.WriteLine("___");
            Console.WriteLine();
            rogor.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("___");
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("___");
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("___");
            Console.WriteLine();

            rogor.AttackP();
            rogor.Lvlup(5);
            rogor.ShowInfo();
            rogor.Lvlup(15);
            rogor.ShowInfo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            rogor.Int = 10;
            rogor.FallMan();
            rogor.ShowInfo();

        }

    }
}
