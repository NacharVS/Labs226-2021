using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class TwoArrays
    {
        public static void Arrays2(int[] array, int[] array2)
        {
            

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
                for (int d = i + 1; d < array.Length; d++)
                {
                    if (array[i] == array[d])
                    {
                        array[d] = 0;
                    }
                }
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j])
                    {

                        Console.Write(" " + $"{array2[j]}");
                        array[i] = 0;
                    }
                }
            }
        }
    }
}
