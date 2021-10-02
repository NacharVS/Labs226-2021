using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class ForOperation
    {
        public static void zadacha0()
        {
            Console.WriteLine("Введите три числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b & a > c) Console.WriteLine(" max - " + a);
            if (b > a & b > c) Console.WriteLine(" max - " + b);
            if (c > b & c > a) Console.WriteLine(" max - " + c);

            if (a < b & a < c) Console.WriteLine(" min - " + a);
            if (b < a & b < c) Console.WriteLine(" min - " + b);
            if (c < b & c < a) Console.WriteLine(" min - " + c);

            if (a > b & a < c) Console.WriteLine("Среднее  - " + a);
            if (b > a & b < c) Console.WriteLine("Среднее  - " + b);
            if (c > b & c < a) Console.WriteLine("Среднее  - " + c);
            if (a > c & a < b) Console.WriteLine("Среднее  - " + a);
            if (b > c & b < a) Console.WriteLine("Среднее  - " + b);
            if (c > a & c < b) Console.WriteLine("Среднее  - " + c);
        }
        public static void zadacha1()
        {
            Console.WriteLine("Vvedi chislo i stepen");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int c = 1;
            while (b != n)
            {
                b++;
                c *= a;
            }
            Console.WriteLine(b);
        }
        public static void zadacha2()
        {
            Console.WriteLine("Введите ваше действие (+, *, -, /,)");
            string x = (Console.ReadLine());
            string a = "+";
            string b = "*";
            string c = "-";
            string d = "/";
            if (x == a)
            {
                Console.WriteLine("Введите два числа и я выведу их сумму");
                double s = Convert.ToInt32(Console.ReadLine());
                double q = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сумма ваших чисел = " + (s + q));
            }
            if (x == b)
            {
                Console.WriteLine("Введите два числа и я выведу их произведение");
                double s = Convert.ToInt32(Console.ReadLine());
                double q = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Произведение ваших чисел = " + (s * q));
            }
            if (x == c)
            {
                Console.WriteLine("Введите два числа и я выведу их разность");
                double s = Convert.ToInt32(Console.ReadLine());
                double q = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Разность ваших чисел = " + (s - q));
            }
            if (x == d)
            {
                Console.WriteLine("Введите два числа и я выведу их Деление");
                double s = Convert.ToInt32(Console.ReadLine());
                double q = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Деление ваших чисел = " + (s / q));
            }
        }
    }
}
 
    




