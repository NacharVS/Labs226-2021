using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(int[] array)
        {
            int min = 100; int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($" {array[i]}");
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"max = {max} min = {min}");
        }
    }
}
