using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень");
            int b = int.Parse(Console.ReadLine());
            int k = a;
            int i = 0;
            while (i != b)
            {
                a = a * k;
                    i = i + 1;
            }
            Console.WriteLine($"Число {k} в {b} равняется {a}");
        }
    }
}
