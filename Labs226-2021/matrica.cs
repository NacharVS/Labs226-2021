using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class matrica
    {
        public static void MaxElementRow()
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
                    Console.WriteLine($" max element v {i + 1} stroke = {max}");
                }
                else
                {
                    Console.WriteLine($" max element v {i + 1} stroke = {max}");
                }
            }
        }

        public static void DiagonalMatrix()
        {
            int[,] array = new int[5, 5];
            int res = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 50);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int h = 0; h < array.GetLength(0); h++)
            {
                res = res + array[h, h];
                
            }

            Console.WriteLine();
            Console.WriteLine(res);
        }
    }
}