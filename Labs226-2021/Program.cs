using System;
using System.Collections.Generic;
using System.Text;
using Labs226_2021.Strategy;

namespace Labs226_2021
{
    class Program
    {

 

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

