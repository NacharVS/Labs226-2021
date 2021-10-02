using System;
using System.Collections.Generic;
using System.Text;

namespace D-7
{
    class ArraysFirst
    {
        public static void MaxMin(int[] array)
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
            Console.WriteLine($"max = {max} min = {min}");
        }

        public static void Umno(int[] array, int[] array2)
        {

            int[] array3 = new int[10];

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
                array3[i] = array[i] + array2[i];
            }
            Console.WriteLine();

            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write($" {array3[i]}");
            }
        }

    
