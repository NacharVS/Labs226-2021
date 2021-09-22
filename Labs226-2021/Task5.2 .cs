using System;

namespace ConsoleApp4
{
    class Program52
    {
        static void Main (string[] args)
        {
            int[] array = new int[10];
            int[] array2 = new int[10];
            Random rnd = new Random();
            int[] array3 = new int[10];
            for (int i = 0; i<array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
                
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(10, 100);

            }
            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i] * array2[i];
                Console.WriteLine($" array3[i]");
            }
            
        }

    }
}
