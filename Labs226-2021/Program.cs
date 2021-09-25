using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 50);
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
