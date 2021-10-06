using System;

namespace ConsoleApp2
{
    class Metod
    {
        public static void ArrayGeneration(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(2);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayGeneration(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(2);
                Console.Write($"{array[i]} ");
            }
        }

        public static void ArrayGeneration(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(n);
                Console.Write($"{array[i]} ");
            }
        }
        public static void ArrayGeneration(int[,] array, int n)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(n);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayGeneration(int[] array, int n, int m)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(n, m);
                Console.Write($"{array[i]} ");
            }
        }
        public static void ArrayGeneration(int[,] array, int n, int m)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(n ,m);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }



    }
}


