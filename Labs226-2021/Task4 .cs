using System;

namespace Labs226_2021
{
    class Program
    {
        static void Task4(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c = 0;
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine(c);

        }
    }
}