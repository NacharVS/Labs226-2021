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

                Console.WriteLine($"Name: {item.nameOfProduct}, Price:{item.price}, Count: {item.countOfProduct}, Manufacturer: {item.manufacturer}");
            }



        }

        //static void ShowMessage(double balance, double old, double diff)
        //{
        //    Console.WriteLine($"Balance has changed! Old Balance {old} Current balance {balance}. Difference {diff}");
        //}
    }
}
