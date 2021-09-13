using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
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

    }
}
