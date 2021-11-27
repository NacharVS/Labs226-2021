using System;

namespace ConsoleApp2
{
    class Program3
    {
        static void MaxMinNumber ()
        {
            Console.WriteLine("Введите первое чило");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе чило");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третие чило");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Минимальное зеачение");
            Console.WriteLine(Math.Min(Math.Min(a, b), c));
            Console.WriteLine("Максимальное зеачение");
            Console.WriteLine(Math.Max(Math.Max(a, b), c));
            if (a < b & a > c) { Console.WriteLine("Cреднее значение"); Console.WriteLine(a); }
            else if (a < c & a > b) { Console.WriteLine("Cреднее значение"); Console.WriteLine(a); }
            else if (b < c & b > a) { Console.WriteLine("Cреднее значение"); Console.WriteLine(b); }
            else if (b < a & b > c) { Console.WriteLine("Cреднее значение"); Console.WriteLine(b); }
            else if (c < b & c > a) { Console.WriteLine("Cреднее значение"); Console.WriteLine(c); }
            else if (c < a & c > b) { Console.WriteLine("Cреднее значение"); Console.WriteLine(c); }

        }
        static void BankVklad ()
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
        static void Kalkulator ()
        {
            Console.WriteLine("Выберете действие + - * /");
            Console.WriteLine(" +  = 1 " +
                "- = 2 " +
                "* = 3" +
                "/ = 4");


            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите певое чилов");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторе чило");
            int d = int.Parse(Console.ReadLine());
            int r = 0;
            if (a == 1) { r = c + d; Console.WriteLine(r); }
            else if (a == 2) { r = c - d; Console.WriteLine(r); }
            else if (a == 3) { r = c * d; Console.WriteLine(r); }
            else if (a == 4) { r = c / d; Console.WriteLine(r); }
            else { Console.WriteLine("Выберети верное заначение действия"); }
        }


    }
}
