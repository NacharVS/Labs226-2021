using System;

namespace Заданиие_0
{
    class IfOperator
    {
        static void Sr_Max_Min(string[] args)
        {
            Console.WriteLine("Введите число А:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B:"); 
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число C:");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c && b > c)
                Console.WriteLine("Число A больше всех, число B - среднее, число С меньше всех");
            else if (a > b && a > c && b < c)
                Console.WriteLine("Число A больше всех, число C - среднее, число B меньше всех");
            else if (b > c && a > c)
                Console.WriteLine("Число B больше всех, число А - среднее, число С меньше всех");
            else if (b > c && a < c)
                Console.WriteLine("Число B больше всех, число C - среднее, число A меньше всех");
            else if (c > b && a < b)
                Console.WriteLine("Число C больше всех, число B - среднее, число A меньше всех");
            else if (c > a && a > b)
                Console.WriteLine("Число C больше всех, число A - среднее, число C меньше всех");
        }
        static void BankSProcentami(string[] args)
        {
            Console.WriteLine("Введите сумму вклада, которую вы хотите внести в наш банк:");
            int a = int.Parse(Console.ReadLine());
            if (a <= 100)
                Console.WriteLine("Число процента годовых будет составлять 0");
            else if (a > 100 && a <= 1000)
                Console.WriteLine("Число процента годовых будет составлять 5");
            else if (a > 1000 && a <= 5000)
                Console.WriteLine("Число процента годовых будет составлять 7");
            else if (a > 5000 && a <= 50000)
                Console.WriteLine("Число процента годовых будет составлять 9");
            else (a > 50000)
                Console.WriteLine("Число процента годовых будет составлять 12");
        }
        static void Kalkulyator(string[] args)
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
