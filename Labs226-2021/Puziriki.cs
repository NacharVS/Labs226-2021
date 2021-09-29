using System;

namespace ConsoleApp3
{
    class Program0
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($"{array[i]} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int buf = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buf;
                    }
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                for (int k = 0; k < array.Length; k++)
                {
                    Console.Write($"{array[k]} ");
                }

            }
        }
    }
}