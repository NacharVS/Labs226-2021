using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Matrix
    {
        public static void MatrixOne(int[,] array)
        {
            int[,] array = new int[8, 8];
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 101);
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
                    for (int h = 0; h < array.GetLength(0); h++)
                    {
                        int b = array[i, h];
                        if (max < b)
                        {
                            max = b;
                        }
                    }
                }

                if (i + 1 == 2)
                {
                    Console.WriteLine($" {i + 1} = {max}");
                }

            }
        }

        public static void MatrixTwo(int[,] array)
        {
            int a = 0;
            

            int[,] array = new int[8, 8];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == i)
                {
                    a = a + array[i, i];
                }
            }
            Console.WriteLine(a);

        }
    }
}
