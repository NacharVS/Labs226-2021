using System;

namespace Задача_0
{
    class Program
    {
        static void Main12345(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = int.Parse(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.WriteLine("Число A самое большое, B среднее и C меньшее");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("Число B самое большое, A среднее и C меньшее");
            }
            else if (c > b && b > a)
            {
                Console.WriteLine("Число C самое большое, B среднее и A меньшее");
            }
            else if (b > c && c > a)
            {
                Console.WriteLine("Число B самое большое, C среднее и A меньшее");
            }
            else if (c > a && a > b)
            {
                Console.WriteLine("Число C самое большое, A среднее и B меньшее");
            }
            else if (a > c && c > b)
            {
                Console.WriteLine("Число A самое большое, C среднее и B меньшее");
            }
            int g = int.Parse(Console.ReadLine());
        }

        
    }
}
