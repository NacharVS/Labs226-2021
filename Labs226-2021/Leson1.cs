using System;

namespace Labs226_2021
{
    class Leson1
    {
        static void task1(string[] args)
        {
            int a = 2;
            int b = 5;
            a = b - a;
            b = b - a;
            a = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void task2(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            Double Pi = 3.14;
            Double S = 0;
            S = 4 * Pi * (r * r);
            Console.WriteLine(S);
        }
        static void task3 (string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 1;
            Double S = 0;
            Double P = 0;
            Double p = 0;
            Double V = 0;
            S = a * b;
            P = 2 * (a + b);
            p = a + b;
            V = a * b * c;
            Console.WriteLine(S);
            Console.WriteLine(P);
            Console.WriteLine(p);
            Console.WriteLine(V);
        }
        static void task4(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c = 0;
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine(c);

        }

    }
}
