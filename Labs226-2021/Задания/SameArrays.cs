using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class SameArrays
    {
        public static void SameArr(int[] array, int[] array2)
        {
/* Генерация ячеек массива */
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();

            /* Заполнение ячеек массива */
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(1, 10);
                Console.Write($" {array2[i]}");
            }
            /* 2 для вывода 2х вещей построчно */
            Console.WriteLine();
            Console.WriteLine();

            /* Создание второго индетичного массива для 
            сравнения и приравнивание одинаковых числел ячеек к 0 */
            for (int i = 0; i < array.Length; i++)
            {
                for (int c = i + 1; c < array.Length; c++)
                {
                    if (array[i] == array[c])
                    {
                        array[c] = 0;
                    }
                }

                /* Принт значений ячеек */
                for (int g = 0; g < array2.Length; g++)
                {
                    if (array[i] == array2[g])
                    {

                        Console.Write(" " + $"{array2[g]}");
                        array[i] = 0;

                    }


                }
            }
        }
    }
}
