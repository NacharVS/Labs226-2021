using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class ArraysFirst
    {
        public static void MaxMin(int[] array)
        {

            int min = 10; int max = array[0];

            /* Создание, заполнение и нахождение мин макс значение массива */
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 10);
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

            /* Создание 2х строк массива и их заполнение */
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 2);
                array2[i] = new Random().Next(0, 2);
                Console.Write($" {array[i]}");
            }

            Console.WriteLine();

            /* Сложение строк массива поячеечно */
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
    }
}