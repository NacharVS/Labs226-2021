using System;

namespace ConsoleApp4
{
    class Program51
    {
        static void Main (string[] args)
        {
            int[] array = new int[10];
             Random rnd = new Random();
            int max = 0;
            int min = 0; 
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
            }
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] < min )
                { 
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($" max");
            Console.WriteLine($" min");
        }

    }
}
