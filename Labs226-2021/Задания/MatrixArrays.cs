using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Matrica
    {
        public static void MaxElementVStroke(int[,] array)
        {
            int max = 0;
            /* Генерация матрицы при помощи массивов */
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

            /* Заполнение ячеек массивов */
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(0); j++)
                {
                    max = array[i, j];

                    /* Принт результата */
                    for (int s = 0; s < array.GetLength(0); s++)
                    {
                        int c = array[i, s];
                        if (max < c)
                        {
                            max = c;
                        }
                    }
                }

                if (i + 1 == 2)
                {
                    Console.WriteLine($" Макс элемент во {i + 1}-ой строке = {max}");
                }
                else
                {
                    Console.WriteLine($" Макс элемент в {i + 1}-ой строке = {max}");
                }
            }
        }


        public static void SumDiagonal(int[,] array)
        {
            int res = 0;

            /* Генерация и заполение матрицы при помощи массивов */
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 50);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            /* Нахождение суммы значений диагонали */
            for (int s = 0; s < array.GetLength(0); s++)
            {
                res = res + array[s, s];

            }
            Console.WriteLine();
            Console.WriteLine(res);
        }
    }
}
