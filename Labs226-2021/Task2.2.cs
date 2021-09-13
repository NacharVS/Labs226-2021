using System;

namespace Labs226_2021
{
    class Program
    {
        static void Task22(string[] args)
        {
            Console.WriteLine("Сумма вклада");
            int a = int.Parse(Console.ReadLine());
            double d = 0;

            if (a <= 100)
            {
                d = a; Console.WriteLine("Вклад с учетом процентов будет равен");
                Console.WriteLine(d);
            }
            else if (a <= 1000)
            {
                d = a + 0.05 * a; Console.WriteLine("Вклад с учетом процентов будет равен");
                Console.WriteLine(d);
            }
            else if (a <= 5000)
            {
                d = a + 0.07 * a; Console.WriteLine("Вклад с учетом процентов будет равен");
                Console.WriteLine(d);
            }
            else if (a <= 50000)
            {
                d = a + 0.09 * a; Console.WriteLine("Вклад с учетом процентов будет равен");
                Console.WriteLine(d);
            }
            else if (a > 50000)
            {
                d = a + 0.12 * a; Console.WriteLine("Вклад с учетом процентов будет равен");
                Console.WriteLine(d);
            }

        }
    }
}