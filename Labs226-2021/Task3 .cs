using System;

namespace Labs226_2021
{
    class Program
    {
        static void Task3(string[] args)
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
    }
}
