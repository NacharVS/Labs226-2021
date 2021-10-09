using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В МАГАЗИН");
            Console.WriteLine("");
            Console.WriteLine("Хотите ли вы сделать покупку?(Если да - введите 1, если нет - введите 2):");
            int b = int.Parse(Console.ReadLine());
            Kibet.Magazine(b);
        }
    }
}
