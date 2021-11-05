using System;
using System.Collections.Generic;
using System.Text;
using Labs226_2021.Strategy;

namespace Labs226_2021
{
    class Program
    {
<<<<<<< HEAD
        //static void Main ()
        //{

        //    Mage WarriorArcher = new Mage ();
        //    Healer Warrior = new Healer();
        //    WarriorArcher.Name = "Warrior"; Warrior.Name = "Warior";

        //          Warrior.MinDamage = 15;                                                     WarriorArcher.Health = 50; 
        //    WarriorArcher.MaxDamage = 10; WarriorArcher.MinDamage = 7; Warrior.MaxDamage = 20; Warrior.Health = 50;
        //    Warrior.Healing = 45;
        //    while (WarriorArcher.Health != 0 && Warrior.Health != 0)
        //    {
        //        Actions.WarriorVSArcher(WarriorArcher, Warrior);
        //    }


        //}

        static void Main()
        {
            int F = 0;
            int b = 0;
            int d = 0;
            string a = "";
            corzina[] corzinaa = new corzina[3];
            corzinaa[0] = new corzina("0", 0, 0);
            corzinaa[1] = new corzina("0", 0, 0);
            corzinaa[2] = new corzina("0", 0, 0);
            Product[] products = new Product[5];
            products[0] = new Product("Maionez", 80, 20);
            products[1] = new Product("Milk", 60.25, 100);
            products[2] = new Product("Bread", 30, 40);
            products[3] = new Product("Cheeze", 324.5, 20);
            products[4] = new Product("Egg", 130, 50);

            foreach (var item in products)
            {
                Console.WriteLine($"{item.name}  - {item.prise} rub - {item.qouter}");
=======
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
>>>>>>> 7dc46896327904c8f11eb3eca1b17fb64a241b66
            }
            if (corzinaa[2].name == "0")
            {
                foreach (var iteme in corzinaa)
                {
                    Console.WriteLine("Выберете название продукта ");
                    a = Console.ReadLine();
                    Console.WriteLine("Напишите количество продукции ");
                    d = int.Parse(Console.ReadLine());
                    
                    if (corzinaa[0].name != "0")
                    {

                        if (corzinaa[1].name != "0")
                        {
                            if (corzinaa[2].name != "0")
                            {
                                

                                if (products[0].name == a)
                                {
                                    corzinaa[F].name = a;
                                    corzinaa[F].kolvo =b+ corzinaa[F].kolvo;
                                    corzinaa[F].chena = products[F].prise;
                                }
                                else if (products[1].name == a)
                                {
                                    corzinaa[F].name = a;
                                    corzinaa[F].kolvo = b+ corzinaa[F].kolvo;
                                    corzinaa[F].chena = products[F].prise;
                                }
                                else if (products[2].name == a)
                                {
                                    corzinaa[F].name = a;
                                    corzinaa[F].kolvo = b+ corzinaa[F].kolvo;
                                    corzinaa[F].chena = products[F].prise;
                                }

                                else if (products[3].name == a)
                                {
                                    corzinaa[F].name = a;
                                    corzinaa[F].kolvo = b+ corzinaa[F].kolvo;
                                    corzinaa[F].chena = products[F].prise;
                                }
                                else if (products[4].name == a)
                                {
                                    corzinaa[F].name = a;
                                    corzinaa[F].kolvo = b+ corzinaa[F].kolvo;
                                    corzinaa[F].chena = products[F].prise;
                                   
                                }
                               
                            }
                        }
                    }
                    foreach (var item in corzinaa)
                    {
                        Console.WriteLine($"{item.name}  - {item.chena} rub - {item.kolvo}");                     
                    }
                    F = F + 1; ;
                }
                F = F + 1; ;
            }
        }
    }
}

