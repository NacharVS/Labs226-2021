using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];

            products[0] = new Product("Maionez", 80, 20);
            products[1] = new Product("Milk", 60.25, 100);
            products[2] = new Product("Bread", 30, 40);
            products[3] = new Product("Cheeze", 324.5, 20);
            products[4] = new Product("Egg", 130, 50);

            foreach (var item in products)
            {
                if(item.price > 50)
                    Console.WriteLine(item.nameOfProduct);
            }






        }
    }
}
