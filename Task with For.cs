using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class SameArrays
    {
        public static void SameArr()
        {
            int[] array = new int[10];
            int[] array2 = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($" {array[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(1, 10);
                Console.Write($" {array2[i]}");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                for (int c = i + 1; c < array.Length; c++)
                {
                    if (array[i] == array[c])
                    {
                        array[c] = 0;
                    }
                }

                for (int g = 0; g < array2.Length; g++)
                {
                    if (array[i] == array2[g])
                    {

                        Console.Write(" " + $"{array2[g]}");
                        array[i] = 0;

                    }
                    

                }
            }
        }
    }
}