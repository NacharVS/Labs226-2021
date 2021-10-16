using System;

namespace Catalog
{
    class Shop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в наш магазин, здесь вы найдете множество нужных вам вещей!");
            Console.WriteLine("Ознакомьтесь с каталогом:");
            Console.WriteLine(" ");
            int c = 0;
            double b = 0;
            double[] cart = new double[10];
            string[] array = { "0. Меч паладина - 500 золотых за шт. ", "1. Молот Одина - 999 золотых за шт. ",  "2. Драконий щит - 20000 золотых за шт. ", "3. Зелье маны - 100 золотых за шт. ", 
                "4. Зелье здоровья - 100 золотых за шт. ",  "5. Порох - 70 золотых за 1кг. ", "6. Пыльца феи 120 золотых за 1кг. ", "7. Железный порошок 49 золотых за 1кг. ",
                "8. Чешуя дракона 499 золотых за 1кг. ", "9. Прах монстра 15 золотых за 1кг. "};
            
            Console.WriteLine("Товары поштучно:");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Товары на развес:");
            Console.WriteLine();
            for (int i = 5; i<array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Выберите желаемый номер товара для добавления в корзину(вводить по одному числу, без точек)");
            Console.WriteLine("Если хотите перейти к корзине, то введите число '11'");
            int a = 0;
            while (a != 1)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите товар: ");
                c = int.Parse(Console.ReadLine());
                
                Console.WriteLine("укажите его кол-во или Кг");
                b = double.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[1]}");
                }
                else if(c == 2)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[2]}");
                }
                else if (c == 3)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[3]}");
                }
                else if (c == 4)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[4]}");
                }
                else if (c == 5)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[5]}");
                }
                else if (c == 6)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[6]}");
                }
                else if (c == 7)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[7]}");
                }
                else if (c == 8)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[8]}");
                }
                else if (c == 9)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[9]}");
                }
                else if (c == 10)
                {
                    Console.WriteLine($"Вы добавили в корзину: {array[10]}");
                }

                Console.WriteLine();
                Console.WriteLine("если хотите прекратить покупки напишите 1");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Коллво/Весс товаров");
            Console.WriteLine($"Меч паладина - {cart[0]} на сумму {b * 500} золотых");
            Console.WriteLine($"Молот Одина - {cart[1]} на сумму {b * 999} золотых");
            Console.WriteLine($"Драконий щит - {cart[2]} на сумму {b * 20000} золотых");
            Console.WriteLine($"Зелье маны - {cart[3]} на сумму {b * 100} золотых");
            Console.WriteLine($"Зелье здоровья - {cart[4]} на сумму {b * 100} золотых");
            Console.WriteLine($"Порох - {cart[5]}кг  на сумму {b * 70} золотых");
            Console.WriteLine($"Пыльца феи - {cart[6]}кг на сумму {b * 120} золотых");
            Console.WriteLine($"Железный порошок - {cart[7]}кг на сумму {b * 49} золотых");
            Console.WriteLine($"Чешуя дракона - {cart[8]}кг на сумму {b * 499} золотых");
            Console.WriteLine($"Прах монстра - {cart[9]}кг на сумму {b * 15} золотых");
            Console.WriteLine();

        }
    }
}
