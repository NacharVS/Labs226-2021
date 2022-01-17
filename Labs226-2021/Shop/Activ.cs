using Labs226_2021.Shop;
using Labs226_2021.Strategy;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Labs226_2021.Shop
{
    class Activ
    {

        public static void Magaz()
        {
            Product putter = new Product("Putter", 800.99, 10, "Larsen", "Самокат");
            Product bread = new Product("Bread", 40, 180, "China", "Самокат");
            Product shampoo = new Product("Shampoo", 200, 100, "Vietnam", "Самокат");
            Product iphone = new Product("IPhone", 120000, 80, "USA", "Самокат");
            Product mouse = new Product("ОКЛИК", 650, 71, "CHINA", "Самокат");
            Product keyboard = new Product("Логитек", 6500, 1, "CHINA", "Самокат");
            Product skateboard = new Product("Apply", 10, 30000, "CHINA", "Самокат");
            Product blatnienomera = new Product("777", 777, 777, "CHINA777", "Самокат");
            Product chakchak = new Product("чак-норис", 116, 16, "TARSTAN", "Самокат");
            Product teate = new Product("Чай-норис", 611, 61, "NATSRAT", "Самокат");

            List<Product> products = new List<Product>();

            products.Add(putter);
            products.Add(bread);
            products.Add(shampoo);
            products.Add(iphone);
            products.Add(mouse);
            products.Add(keyboard);
            products.Add(skateboard);
            products.Add(blatnienomera);
            products.Add(chakchak);
            products.Add(teate);

            foreach (var item in products)
            {
                

                Console.WriteLine($"Name: {item.nameOfProduct}, Price:{item.price}, Count: {item.countOfProduct}, Manufacturer: {item.manufacturer}");
            }


        }

    }
}

