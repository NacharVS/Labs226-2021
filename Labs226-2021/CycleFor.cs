using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class CycleFor
    {
        public static void Degree()
        {
            Console.WriteLine("vashe chislo: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("vasha stepen: ");
            int b = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;

            }
            Console.WriteLine();
            Console.WriteLine($"Число {a} в степени {b}: ");
            Console.WriteLine(result);


        }
        public static void Reverse()
        {
            Console.WriteLine("1234 - 4321");
            Console.WriteLine("vashe chislo: ");
            int a = int.Parse(Console.ReadLine());
            int result = 0;

            while (a > 0)
            {
                result *= 10;
                result += a % 10;
                a /= 10;
            }
            Console.WriteLine(result);

        }
    }
}