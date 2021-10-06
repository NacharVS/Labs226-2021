using System;

namespace Задание_0
{
    class ArrayObichnie
    {
        static void PohozhieElementsNull(int[] array)
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
        static void MinMaxMassiva(int[] array)
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
        static void SummUmno(int[] array, int[] array, int[] array)
        {

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
                Console.Write($"Сумма массивов {array3[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                array3[i] = array[i] * array2[i];
            }
            Console.WriteLine();

            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write($"Произведение массивов {array3[i]}");
            }
        }
    }
}
