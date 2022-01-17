using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Shop
{
    class Store
    {


        public static void Magaz()
        {

            Product putter = new Product("Putter", 800, 10, "Larsen", "Самокат");
            Product bread = new Product("Bread", 40, 180, "China", "Самокат");
            Product shampoo = new Product("Shampoo", 200, 100, "Vietnam", "Самокат");
            Product iphone = new Product("IPhone", 120000, 80, "USA", "Самокат");
            Product mouse = new Product("ОКЛИК", 650, 71, "CHINA", "Самокат");
            Product keyboard = new Product("Логитек", 6500, 1, "CHINA", "Самокат");
            Product skateboard = new Product("Apple", 10, 30000, "CHINA", "Самокат");
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


            int tovar = 0;
            int YesNo = 1;
            int Yes = 1;
            int l = 0;
            int quantity = 0;


            List<Product> basket = new List<Product>();

            ProductList(products);
            Console.WriteLine();

            Console.WriteLine("Вы хотите что-нибудь приобрести?");
            Console.WriteLine("1. Да \n2. Нет");
            YesNo = int.Parse(Console.ReadLine());
            Console.Clear();

            ProductList(products);
            Console.WriteLine();

            ProductSelection(YesNo, Yes, products, tovar, quantity, basket);



            


            

        }

        public static void ProductSelection(int YesNo, int Yes, List<Product> products, int tovar, int quantity, List<Product> basket)
        {
            List<int> quantitylist = new List<int>();

            while (YesNo == Yes)
            {
                Console.Clear();
                ProductList(products);
                Console.WriteLine("Выберите позицию товара: ");
                tovar = int.Parse(Console.ReadLine());
                tovar -= 1;

                Console.WriteLine($"Укажите кол-во {products[tovar].nameOfProduct}: ");
                quantity = int.Parse(Console.ReadLine());
                if (quantity <= products[tovar].countOfProduct)
                {
                    quantitylist.Add(quantity);
                    basket.Add(products[tovar]);
                    products[tovar].countOfProduct -= quantity;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы превысили количество товара!!! Доступно {products[tovar].countOfProduct}");
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Вы хотите продолжить? (1. Да / 2. Нет)");

                Yes = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            int num = 1;
            





            Console.WriteLine("Корзина: ");
            Console.WriteLine("  Цена     Кол-во    Итог");
            Console.WriteLine("============================");
            foreach (Product product in basket)
            {

                int numQ = num - 1;
                Console.WriteLine($"{num}. {product.nameOfProduct}");
                Console.WriteLine($"  {product.price}       {quantitylist[numQ]}       {product.price * quantitylist[numQ]}");
                num++;

            }

        }

        public static void ProductList(List<Product> products)
        {
            int i = 1;
            foreach (var item in products)
            {


                Console.Write($"{i}. {item.nameOfProduct}, ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Price:{item.price}, ");
                Console.ResetColor();
                Console.WriteLine($"Count: {item.countOfProduct}, Manufacturer: {item.manufacturer}");
                i++;
            }

        }

        
    }
}
