using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class PrimaryTasks
    {
        public static void Zero()
        {
            Console.Write("Введите число 'a': ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число 'b': ");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($" a = {a}");
            Console.WriteLine($" b = {b}");
        }

        public static void First()
        {
            Console.Write("Введите R: ");

            int R = int.Parse(Console.ReadLine());
            double S = 4 * Math.PI * (R * R);

            Console.WriteLine($" S = {S}");

        }

        public static void Second()
        {
            Console.Write("Сторона а: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Сторона b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Сторона c: ");
            int c = int.Parse(Console.ReadLine());

            int S = a * b;
            int P = 2 * (a + b);
            int V = a * b * c;
            int p = a + b;

            Console.WriteLine($"S= {S}, P= {P}, V= {V}, p= {p}");
        }
        public static void Third()
        {
            Console.Write("Сторона а: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Сторона b: ");
            int b = int.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine($"Гипотенуза = {c}");

        }
    }
}
