using System;

namespace SummMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] array = new int[4, 4];
            int[,] array1 = new int[4, 4];
            Console.WriteLine("Первый массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                    Console.Write($" { array[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Второй массив:");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = rnd.Next(0, 2);
                    Console.Write($" { array1[i, j]}");

                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Сумма массивов:");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j] + array1[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
