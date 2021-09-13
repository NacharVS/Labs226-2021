using System;

namespace Labs226_2021
{
    class Program
    {
        static void Task2(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            Double Pi = 3.14;
            Double S = 0;
            S = 4 * Pi * (r*r);
            Console.WriteLine(S);
            
        }
    }
}
