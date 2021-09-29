using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
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

}