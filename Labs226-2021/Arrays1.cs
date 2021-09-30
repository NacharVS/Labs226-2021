using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Arrays1
    {
        public static void MaxMinElement(int[] array)
        {
            
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

        public static void Multiplication(int[] array, int [] array2, int [] arrayResuilt)
        {
            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 10);
                array2[i] = new Random().Next(0, 10);
                Console.Write($" {array[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($" {array2[i]}");
                arrayResuilt[i] = array[i] + array2[i];
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arrayResuilt.Length; i++)
            {
                Console.Write($" {arrayResuilt[i]}");
            }
        }

        public static void SameElements(int [] array)
        {
            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($" {array[i]}");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
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
