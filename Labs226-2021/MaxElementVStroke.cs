using System;

namespace ConsoleApp3
{
    class Program
    {
        static void MaxElementVStroke(int[,] array)
        {
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

                Console.WriteLine($" Максимальный элемент {i + 1}-ой строки = {max}");

            }
        }
    }
}
