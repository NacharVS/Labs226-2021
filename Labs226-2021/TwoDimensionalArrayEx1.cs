using System;

namespace ConsoleApp3
{
    class Program087
    {
        static void Main1234(string[] args)
        {
            int[,] array = new int[10, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 50);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}