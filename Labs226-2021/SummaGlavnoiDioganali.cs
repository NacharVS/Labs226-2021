using System;

namespace ConsoleApp3
{
    class Program
    {
        static void SummaGlavnoiDiagonali(int[,] array)
        {
            int Summa = 0;

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
            Console.WriteLine($"Сумма главной диагонали равна {Summa} ");
        }
    }
}
