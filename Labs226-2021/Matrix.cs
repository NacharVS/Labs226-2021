using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Matrix
    { 


        public static void Matrix1()
        {
            int[,] arrayRes2 = new int[10, 2];
            int[,] arrayRes = new int[10, 2];
            int max2 = 0;
            int max = 0;            
            Random rnd = new Random();
            int sum = 0;
            int[] sumst = new int[10];
            int[,] array = new int[10, 10];
            int[,] arrayy = new int [10,2];
            for (int i =0; i<array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                    Console.Write( $" { array[i,j]}"  );
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];                 
                }
                sumst[i] = sum;
                sum = 0;
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {   
                    Console.Write($" { array[i, j]}");
                }
                Console.Write($" { sumst[i]}");
                Console.WriteLine();
            }                              
            for (int j = 0; j < arrayy.GetLength(0); j++)
            {
              arrayy[j, 0] = sumst[j];
            }
            for (int j = 0; j < arrayy.GetLength(0); j++)
            {
              arrayy[j, 1] = j;
            }
            for (int i = 0; i < arrayy.GetLength(0); i++)
            {
              for (int j = 0; j < arrayy.GetLength(1); j++)
              {
               Console.Write($" { arrayy[i,j]}");
              }
              Console.WriteLine();         
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("По убыванию суммы");
            for (int j = 0; j < arrayy.GetLength(0); j++)
            { 
              for (int i = 0; i < arrayy.GetLength(0); i++)
              {
               if (arrayy[i, 0] > max)
               {
                max = arrayy[i, 0];
                max2 = i;                       
               }
                   
              }
               arrayRes[j, 0] = max;
               arrayRes[j, 1] = max2;              
               Console.Write($" {  arrayRes[j, 0]}");               
               Console.Write($" {  arrayRes[j, 1]}");
               arrayy[max2, 0] = 0;
               max = 0;
               max2 = 0;
               Console.WriteLine();           
            }
            Console.WriteLine("По возростанию суммы");
            for (int j = 0; j < arrayRes2.GetLength(0); j++)
            {
                arrayRes2[j, 0] = arrayRes[9 - j, 0];
                arrayRes2[j, 1] = arrayRes[9 - j, 1];
                Console.Write($" { arrayRes2[j, 0]} ");
                Console.Write($" { arrayRes2[j, 1]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Вывод в порядке убывания");
            for (int j = 0; j < arrayRes.GetLength(0); j++)
            {
             Console.Write($" {  arrayRes[j, 1]}"); 
            }
           
            Console.WriteLine();
            Console.WriteLine("Вывод в порядке возростания");
            for (int j = 0; j < arrayRes.GetLength(0); j++)
            {
                Console.Write($" {  arrayRes2[j, 1]}"); 
            }
        }
    }
}