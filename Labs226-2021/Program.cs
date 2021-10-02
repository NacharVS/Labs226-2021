using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = int.Parse(Console.ReadLine());

            int[,] array = new int[f, f];

            Matrix.DiagonalMatrix(array)
            
        }
    }
}
