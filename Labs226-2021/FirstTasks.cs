using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class FirstTasks
    {
        public static void ZeroTask()
        {
            Console.WriteLine("Введите число 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 'b': ");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($" a - {a}");
            Console.WriteLine($" b - {b}");





        }

        public static void OneTask()
        {
            Console.WriteLine("Введите R: ");
            int R = int.Parse(Console.ReadLine());
            float res = 0;
            float Pi = 3.14f;

            res = 4 * Pi * (R * R);

            Console.WriteLine($" S = {res}");

        }
        public static void TwoTask()
        {
            Console.WriteLine("Сторона а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Сторона b: ");
            int b = int.Parse(Console.ReadLine());

            int c = 1, S, P, V, p;

            S = a * b;
            P = 2 * (a + b);
            V = a * b * c;
            p = a + b;

            Console.WriteLine($"S - {S}, P - {P}, V - {V}, p -{p}");


        }
        public static void ThreeTask()
        {
            Console.WriteLine("Сторона а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Сторона b: ");
            int b = int.Parse(Console.ReadLine());
            double c;

            c = Math.Sqrt(a * a + b * b);

            Console.WriteLine(c);


        }

    }
}
