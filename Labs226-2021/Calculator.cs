using System;

namespace Задача_2
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор.");
            Console.WriteLine("Выберете действие(+, -, /, *)");
            char o = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое значение");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = int.Parse(Console.ReadLine());

            if (o == '+')
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine(a + b);
            }
            else if (o == '-')
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine(a - b);
            }
            else if (o == '/')
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
            else if (o == '*')
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
