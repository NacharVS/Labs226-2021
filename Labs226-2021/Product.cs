using System;
using System.Collections.Generic;

namespace MadeInAntoshaa
{
    class Program
    {
        private const string Value = "Выберите количество: ";

        static void Main(string[] args)
        {
            int[] basket = new int[10];


            Product xn = new Product("xan", 1000, 64, "Ktits", 88001234);
            Product banana = new Product("banana", 20, 600, "Africa", 11223344);
            Product cake = new Product("cake", 500, 10, "CakeWorld", 22334455);
            Product mouse = new Product("mouse", 5000, 100, "DNS", 00000001);
            Product apple = new Product("apple", 5, 600, "Marketplace", 00000002);
            Product bigpen = new Product("bigpen", 700, 7, "Anashop", 22334498);
            Product hleb = new Product("hleb", 5000, 1000, "hlebaa", 22334432);
            Product bionicle = new Product("bionicle", 400, 40, "lego", 22334476);
            Product knigga = new Product("knigga", 777, 666, "kNIGGASS", 22334400);
            Product sofa = new Product("sofa", 7800, 77, "furniture", 22334333);
            List<Product> products = new List<Product>();
            products.Add(xanax);
            products.Add(banana);
            products.Add(cake);
            products.Add(mouse);
            products.Add(apple);
            products.Add(bigpenis);
            products.Add(hleb);
            products.Add(bionicle);
            products.Add(knigga);
            products.Add(sofa);

            string stop = "Нет";
            string ans = "Да";
            int tovar = 0;



            foreach (var item in products)
            {
                Console.WriteLine($"name: {item.name}, price:{item.price}, count: {item.count}, manufacturer: {item.manufacturer}, articulus: {item.articulus}");
                //вывод списка продуктов
            }

            while (stop != ans)
            {
                Console.WriteLine("Выберите позицию товара: ");
                tovar = int.Parse(Console.ReadLine());
                tovar -= 1;

                Console.WriteLine(Value);
                tovar = int.Parse(Console.ReadLine());
                tovar -= 1;



                Console.WriteLine();
                Console.WriteLine("Хотите ли вы продолжить покупку?\nНапишите 'Да' или 'Нет' ");
                ans = Console.ReadLine();
                Console.WriteLine();







            }
        }
    }
}
