using System;

namespace Labs226_2021
{
    class Program1
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
    }
}
