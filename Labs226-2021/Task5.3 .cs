using System;

namespace ConsoleApp4
{
    class Program53
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] array2 = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
                array2[i] = rnd.Next(10, 100);

            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array2[i])
                {
                    array[i] = 0;
                    array2[i] = 0;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");


            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array2[i]}");


            }
        }
        }
}
