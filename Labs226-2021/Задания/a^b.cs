﻿using System;
using System.Collections.Generic;
using System.Text;

namespace a_b
{
    class Program1
    {
        static void Mai6547(string[] args)
        {
            Console.Write("Введите число:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите степень:");
            int b = int.Parse(Console.ReadLine());

            int ctepen = 1;
            for (int i = 0; i < b; i++)
            {
                ctepen *= a;

            }
            Console.WriteLine();

            Console.Write($"Ответ = ");
            Console.Write(ctepen);
        }
    }
}
