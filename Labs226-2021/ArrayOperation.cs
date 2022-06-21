using System;
using Labs226_2021;

namespace Labs226_2021
{
   public  class ArrayOperation
    {
      public static void MaxMinNumber(int[] array)
        {
            Random rnd = new Random();
            int max = 0;
            int min = 1000;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
                Console.Write($"  {array[i]}");
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("") ;
            Console.WriteLine($"max {max}");
            Console.WriteLine($"min {min}");
        }
        public static void SummArray(int[] array, int[] array2)
        {
           
            Random rnd = new Random();
            int[] array3 = new int[10];
            int[] array4 = new int[10];
            for (int i = 0; i < array.Length; i++)
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
                Console.Write($" {array3[i]}");
            }
            for (int i = 0; i < array.Length; i++)
            {
                array4[i] = array[i] + array2[i];
                Console.Write($" {array4[i]}");
            }

        }
        public static void SameElements(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($" {array[i]}");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        array[i] = 0;
                        array[j] = 0;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }





        }
        public static void ArrayLeson2(int[] array, int[] array1)
        {

            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 10);
                Console.Write($" {array[i]}");
                array1[i] = new Random().Next(1, 10);
            }
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($" {array1[i]}");
            }
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
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array[i] == array1[j])
                    {
                        Console.Write(" " + $"{array1[j]}");
                        array[i] = 0;
                    }
                }
            }
        }
          public  static void ArrayMaxin2D(int[,] array)
            {
            int max = -100;

            for (int i = 0; i < 10; i++)
                {
                    
                    for (int j = 0; j < 10; j++)
                    {
                        array[i, j] = new Random().Next(-10, 10);
                        Console.Write($" { array[i, j]}");
                        if (j == 0 || max < array[i, j]) max = array[i, j];

                    }
                   
                    Console.Write($"   max  {max}");
                Console.WriteLine();
                max = -12;
            }
            }
       public static void ArraySummdiagonalOsnandPob(int[,] array)
        {
            
            int sumOsn = 0;
            int sumPob = 0;
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int t = 0; t < array.GetLength(0); t++)
                {
                    array[i, t] = rnd.Next(0, 10);
                    Console.Write($"{ array[i, t]} ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumOsn += array[i, i];
                sumPob += array[i, array.GetLength(0) - i - 1];
            }
            Console.WriteLine($"{ sumOsn} { sumPob}");
        }
    }
}




