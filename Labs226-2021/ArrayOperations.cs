using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
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

        public static void MaxMinElement()
        {
            int[] array = new int[10];
            int min = 100; int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($" {array[i]}");
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"max number - {max} min number -{min}");
        }

        public static void Multiplication()
        {
            int[] array = new int[10];
            int[] array2 = new int[10];
            int[] arrayResuilt = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 2);
                array2[i] = new Random().Next(0, 2);
                Console.Write($" {array[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($" {array2[i]}");
                arrayResuilt[i] = array[i] + array2[i];
            }
            Console.WriteLine();

            for (int i = 0; i < arrayResuilt.Length; i++)
            {
                Console.Write($" {arrayResuilt[i]}");
            }
        }

        public static void SameElements()
        {
            int[] array = new int[10];
      
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($" {array[i]}");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                        array[i] = 0;
                        array[j] = 0;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
    }
}
