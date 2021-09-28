using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class WARS
    {
        public static void TaskOne()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max, min, sred;

            if (a > b && a > c)
                if (b > c)
                {
                    max = a;
                    sred = b;
                    min = c;
                    Console.WriteLine($"{max}, {sred}, {min}");

                }
                else if (c > b)
                {
                    max = a;
                    sred = c;
                    min = b;
                    Console.WriteLine($"{max}, {sred}, {min}");

                }

            if (b > a && b > c)
                if (a > c)
                {
                    max = b;
                    sred = a;
                    min = c;
                    Console.WriteLine($"{max}, {sred}, {min}");
                }
                else if (c > a)
                {
                    max = b;
                    sred = c;
                    min = a;
                    Console.WriteLine($"{max}, {sred}, {min}");
                }

            if (c > a && c > b)
                if (a > b)
                {
                    max = c;
                    sred = a;
                    min = b;
                    Console.WriteLine($"{max}, {sred}, {min}");

                }
                else if (b > a)
                {
                    max = c;
                    sred = b;
                    min = a;
                    Console.WriteLine($"{max}, {sred}, {min}");
                }
        }
        public static void TaskTwo()
        {
            int a = int.Parse(Console.ReadLine());

            double res;
            if (a < 100)
            {
                Console.WriteLine("Ничего");
            }
            else if (a < 1000)
            {
                res = (a * 0.05) + a;
                Console.WriteLine(res);
            }
            else if (a < 5000)
            {
                res = (a * 0.07) + a;
                Console.WriteLine(res);
            }
            else if (a < 50000)
            {
                res = (a * 0.09) + a;
                Console.WriteLine(res);
            }
            else
            {
                res = (a * 0.12) + a;
                Console.WriteLine(res);

            }
        }
        public static void TaskThree()
        {
            int res, num1, num2;
            string plus = "+";
            string minus = "-";
            string ymno = "*";
            string delen = "/";

            string a = (Console.ReadLine());
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (plus == a)
            {
                res = num1 + num2;

                Console.WriteLine(res);
            }

            if (minus == a)
            {
                res = num1 - num2;

                Console.WriteLine(res);
            }

            if (ymno == a)
            {
                res = num1 * num2;

                Console.WriteLine(res);
            }

            if (delen == a)
            {
                res = num1 / num2;

                Console.WriteLine(res);
            }
        }
        public static void TaskFour()
        {
            nt a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 0; i < b; i++)
            {
                res *= a;

            }
            Console.WriteLine(res);
        }
        public static void TaskFive()
        {
            int a = int.Parse(Console.ReadLine());
            int res = 0;

            while (a > 0)
            {
                res *= 10;
                res += a % 10;
                a /= 10;
            }
            Console.WriteLine(res);
        }
    }
}
