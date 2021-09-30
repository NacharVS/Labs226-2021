using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class ForOperation
    {
        public static void Degree()
        {
            Console.WriteLine("Напишите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите степень: ");
            int b = int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 0; i < b; i++)
            {
                res *= a;

            }
            Console.WriteLine();
            Console.WriteLine($"Число {a} в степени {b}: ");
            Console.WriteLine(res);


        }
        public static void Reverse()
        {
            Console.WriteLine("1234 - 4321");
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int res = 0;

            while (a > 0)
            {
                res *= 10;
                res += a % 10;
                a /= 10;
            }
            Console.WriteLine(res);

        }
    }
}
