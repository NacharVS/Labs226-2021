using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете действие(+, -, /, *)");
            char deistvie = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое значение");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = int.Parse(Console.ReadLine());

            if (deistvie == '+')
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine(a + b);
            }
            else if (deistvie == '-')
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine(a - b);
            }
            else if (deistvie == '/')
            {
                if (a > b)
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(a / b);
                }
                else
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(b / a);
                }
            }
            else if (deistvie == '*')
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine(a * b);
            }
            else
            {
                Console.WriteLine("Введенное действие неизвестно");
            }
            int g = int.Parse(Console.ReadLine());
        }
    }
}