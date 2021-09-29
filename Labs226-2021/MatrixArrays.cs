using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class MatrixArrays
    {
        public static void MaxElementVStroke()
        {
            int[,] array = new int[10, 10];
            int max = 0;
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

                for (int j = 0; j < array.GetLength(0); j++)
                {
                    max = array[i, j];
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
                    Console.WriteLine($" Максимальный элемент во {i + 1}-ой строке = {max}");
                }
                else
                {
                    Console.WriteLine($" Максимальный элемент в {i + 1}-ой строке = {max}");
                }
            }
        }

        public static void ArrayDiagonal()
        {
            int[,] array = new int[5, 5];
            int result = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 50);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int s = 0; s < array.GetLength(0); s++)
            {
                result = result + array[s, s];

            }

            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
