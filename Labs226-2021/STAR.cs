using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class STAR
    {
        public static void Task1()
        {
            Console.WriteLine("Введите число в 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число в 'b': ");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a - {a}, b - {b}");
        }

        public static void Task2()
        {
            int R = int.Parse(Console.ReadLine());
            float res = 0;
            float Pi = 3.14f;

            res = 4 * Pi * (R * R);

            Console.WriteLine($"S - {res}");
        }

        public static void Task3()
        {
            Console.WriteLine("Сторона a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Сторона b:");
            int b = int.Parse(Console.ReadLine());
            int c = 1;
            int S;
            int P;
            int V;
            int p;

            S = a * b;
            P = 2 * (a + b);
            V = a * b * c;
            p = a + b;

            Console.WriteLine($"S - {S}, P - {P}, V - {V}, p - {p}");
        }

        public static void Task4()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c1, c2, c;

            c1 = Math.Sqrt(a * a + b * b);

            Console.WriteLine(c1);
        }


    }
}
