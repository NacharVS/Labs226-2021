using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кодовый замок");
            Console.WriteLine("Введите сумму значения");
                int summa = int.Parse(Console.ReadLine());

                for (int i = 0; i < 10; i++)
                {
                    for (int a = 0; a < 10; a++)
                    {
                        for (int b = 0; b < 10; b++)
                        {
                            if (i + a + b == summa)
                            {
                                if (i != a)
                                {
                                    if (a != b)
                                    {
                                        Console.WriteLine($"{ i}{ a}{ b}");
                                    }
                                }

                            }

                        }
                    }
                }
            }
        }
    }