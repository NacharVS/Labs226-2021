using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class array
    {
        public static void summadiagonaley()
        {
            int a = 0;
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 50);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    if (i == j)
                    {
                        a = a + array[i, j];
                    }
                }
            }
            Console.WriteLine(a);
        }
        public static void maxelement()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10, 100);
                Console.Write($"{array[i]} ");
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Максимальное значение массива равно {max}");
        }
    }
}
