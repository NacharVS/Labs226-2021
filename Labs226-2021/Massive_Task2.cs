using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive_task2
{
    class Massive_Task2
    {
        static void Main(int[] array, int[] array2)
        {
            int[] array3 = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 2);
                array2[i] = new Random().Next(0, 2);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($" {array2[i]}");
                array3[i] = array[i] + array2[i];
            }
            Console.WriteLine();

            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write($" {array3[i]}");
            }
        }
    }
}
