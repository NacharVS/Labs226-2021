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
        
        public static void OdinakovieElementiV2array() //Код для нахождения одинаковых элементов двух массивов на одинаковых местах и для превращения их в нули
        {
            int[] massiv1 = new int[10];
            int[] massiv2 = new int[10];

            for (int i = 0; i < massiv1.Length; i++)
            {
                massiv1[i] = new Random().Next(1, 10);
                Console.Write($" {massiv1[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < massiv2.Length; i++)
            {
                massiv2[i] = new Random().Next(1, 10);
                Console.Write($" {massiv2[i]}");
            }

            for (int i = 0; i < massiv1.Length; i++)
            {
                
                for (int j = i + 1; j < massiv1.Length; j++)
                {
                    if (massiv1[i] == massiv2[i])
                    {
                        massiv1[i] = 0;
                        massiv2[i] = 0;
                    }
                }
            }
            for (int i = 0; i < massiv2.Length; i++)
            {
                for (int j = i + 1; j < massiv2.Length; j++)
                {
                    if (massiv1[i] == massiv2[i])
                    {
                        massiv2[i] = 0;
                        massiv1[i] = 0;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Vot resultat");
            for (int i = 0; i < massiv1.Length; i++)
            {
                Console.Write($" {massiv1[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < massiv2.Length; i++)
            {
                Console.Write($" {massiv2[i]}");
            }
        }
    }
}
