using System;

namespace Massive
{
    public class SI
    {
        
        public int[] id = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int sum;
        
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = rand.Next(2);
                    Console.Write($"{array[i, j]}");
                }
                Console.WriteLine();
            }
            void Main2()
            {
                int[] z = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                int[] summ = {0,0,0,0,0,0,0,0,0,0 };
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                        summ[i] += array[i, j];
                    Console.Write($"{summ[i]}", ",");
                    z[i] = summ[i];
                }
                Console.WriteLine();
                    int temp;
                    for (int g = 0; g < z.Length; g++)
                    {
                        for (int h = g + 1; h < z.Length; h++)
                        {
                            if (z[g] > z[h])
                            {
                                temp = z[g];
                                z[g] = z[h];
                                z[h] = temp;
                            }
                        }
                    }
                for (int u = 0; u < 10; u++)
                {
                    Console.Write($"{z[u]}", ",");
                }
            }
            Main2(); 
        }
        
    }
    
}