using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class TaskWithFor
    {
        public static void Stepen()
        {
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите степень: ");
            int b = int.Parse(Console.ReadLine());

            int step = 1;
            for (int i = 0; i < b; i++)
            {
                step *= a;

            }
            Console.WriteLine();
            Console.Write($"Число {a} в {b} степени = ");
            Console.Write(step);
        }

        public static void Rev()
        {
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int rev = 0;

            while (a > 0)
            {
                rev *= 10;
                rev += a % 10;
                a /= 10;
            }
            Console.WriteLine($"Число на оборот = {rev}");
        }
    }
}
