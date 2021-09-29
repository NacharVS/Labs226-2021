using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class TasksWithIf
    {
        public static void MinMaxAvg()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int min, avg, max;

            if (a > b && a > c)
                if (b > c)
                {
                    max = a;
                    avg = b;
                    min = c;
                    Console.Write($" Макс= {max}, Сред= {avg}, Мин= {min}");

                }
                else if (c > b)
                {
                    max = a;
                    avg = c;
                    min = b;
                    Console.Write($"Макс= {max}, Сред= {avg}, Мин= {min}");

                }

            if (b > a && b > c)
                if (a > c)
                {
                    max = b;
                    avg = a;
                    min = c;
                    Console.Write($"Макс= {max}, Сред= {avg}, Мин= {min}");
                }
                else if (c > a)
                {
                    max = b;
                    avg = c;
                    min = a;
                    Console.Write($"Макс= {max}, Сред= {avg}, Мин= {min}");
                }

            if (c > a && c > b)
                if (a > b)
                {
                    max = c;
                    avg = a;
                    min = b;
                    Console.Write($"Макс= {max}, Сред= {avg}, Мин= {min}");

                }
                else if (b > a)
                {
                    max = c;
                    avg = b;
                    min = a;
                    Console.Write($"Макс= {max}, Сред= {avg}, Мин= {min}");
                }
        }
        public static void Vklad()
        {
            int a = int.Parse(Console.ReadLine());

            double result;
            if (a < 100)
            {
                Console.WriteLine("Процентов нет");
            }
            else if (a < 1000)
            {
                result = (a * 0.05) + a;
                Console.Write($"+5% = {result}");
            }
            else if (a < 5000)
            {
                result = (a * 0.07) + a;
                Console.Write($"+7% = {result}");
            }
            else if (a < 50000)
            {
                result = (a * 0.09) + a;
                Console.Write($"+9% = {result}");
            }
            else
            {
                result = (a * 0.12) + a;
                Console.Write($"+12% = {result}");
            }
        }

        public static void Calc()
        {
            int result, num1, num2;
            string p = "+";
            string m = "-";
            string u = "*";
            string d = "/";

            Console.WriteLine("Выберите действие");
            Console.WriteLine("'+' или '-' или '*' или '/'");
            string a = (Console.ReadLine());
            Console.Write("Введите первое число: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            num2 = int.Parse(Console.ReadLine());

            if (p == a)
            {
                result = num1 + num2;

                Console.WriteLine(result);
            }

            if (m == a)
            {
                result = num1 - num2;

                Console.WriteLine(result);
            }

            if (u == a)
            {
                result = num1 * num2;

                Console.WriteLine(result);
            }

            if (d == a)
            {
                result = num1 / num2;

                Console.WriteLine(result);
            }
        }
    }
}
