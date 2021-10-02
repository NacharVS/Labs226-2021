using System;

namespace Задача_1
{
    class Program23
    {
        static void Main2423(string[] args)
        {
            Console.WriteLine("Добро пожаловать в наш банк, прошу ознакомиться с процентными ставками по вкладу:");
            Console.WriteLine("< 100р = 0%");
            Console.WriteLine("100 - 1000р = 5%");
            Console.WriteLine("1000 - 5000р = 7%");
            Console.WriteLine("5000 - 50000р = 9%");
            Console.WriteLine("> 50000 = 12%");
            Console.WriteLine("Введите сумму вклада");
            Console.WriteLine("Вклад = ");
            int d = int.Parse(Console.ReadLine());
            if(d < 100)
            {
                Console.WriteLine("Через год вы получите данную сумму = ");
                Console.WriteLine(d);
            }
            else if (d >= 100 && d <=1000)
            {
                Console.WriteLine("Через год вы получите данную сумму = ");
                Console.WriteLine(d + (d * 0.05));
            }
            else if (d > 1000 && d <= 5000)
            {
                Console.WriteLine("Через год вы получите данную сумму = ");
                Console.WriteLine(d + (d * 0.07));
            }
            else if (d > 5000 && d <= 50000)
            {
                Console.WriteLine("Через год вы получите данную сумму = ");
                Console.WriteLine(d + (d * 0.09));
            }
            else if (d > 50000)
            {
                Console.WriteLine("Через год вы получите данную сумму = ");
                Console.WriteLine(d + (d * 0.12));
            }
            int g = int.Parse(Console.ReadLine());
        }
    }
}
