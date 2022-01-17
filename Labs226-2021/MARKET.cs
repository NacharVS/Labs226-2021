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
            Product putter = new Product("Putter", 800.99, 10, "Larsen");
            Product bread = new Product("Bread", 40, 180, "China");
            Product shampoo = new Product("Shampoo", 200, 100, "Vietnam");
            Product iphone = new Product("IPhone", 120000, 80, "USA");
            List<Product> products = new List<Product>();
            products.Add(putter);
            products.Add(bread);
            products.Add(shampoo);
            products.Add(iphone);

            foreach (var item in products)
            {
                //Console.WriteLine($" {item.nameOfProduct} - cost: " +
                //    $"{item.countOfProduct * item.price}");

                Console.WriteLine($"Name: {item.name}, Price:{item.price}, Count: {item.number}, Manufacturer: {item.nameCreator}");
            }
            putter.SubNum( );
            bread.SubNum();
            shampoo.SubNum();
            iphone.SubNum();


            foreach (var item in products)
            {
                if (item.number < 0)
                {
                    Console.WriteLine("Ошибка!");
                }
                else
                {



                    Console.WriteLine($"Name: {item.name}, Price:{item.price}, Count: {item.number}, Manufacturer: {item.nameCreator}");
                }
            
                }


        }

        //static void ShowMessage(double balance, double old, double diff)
        //{
        //    Console.WriteLine($"Balance has changed! Old Balance {old} Current balance {balance}. Difference {diff}");
        //}
    }
}

