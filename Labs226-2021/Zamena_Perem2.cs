using System;

namespace ConsoleApp3
{
    class Program0
    {
        static void Main12(string[] args)
        {
            Console.WriteLine("Замена переменных");

            Console.WriteLine("Введите значение a");
            Console.WriteLine("a =");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b");
            Console.WriteLine("b =");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a ={a}; b ={b}");

        }
    }
    class Program1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Введите значение b");
            int c = int.Parse(Console.ReadLine());
        }
    }
}


