using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class ArrayOperations
    {
        // 1. Найти максимальное и минимальное значение в массиве
        // 2. Найти сумму и произведение 2х массивов поэлементно
        // 3. Заменить одинаковые элементы массива на 0. *
        public static void Example()
        {
            int[] array = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                    Console.Write($" {array[i + 1]}");
            }
        }
    }
}
