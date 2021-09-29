using System;

namespace ConsoleApp2
{
    class Vozvedenie_v_stepenb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень");
            int b = int.Parse(Console.ReadLine());
            int n = a;
            int i = 0;
            while (i != b)
            {
                a = a * n;
                i = i + 1;
            }
            Console.WriteLine($"Число {n} в {b} равняется {a}");
        }
    }
}
