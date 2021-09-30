using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int tr = int.Parse(Console.ReadLine());

            int[,] array = new int[tr, tr];

            Matrix.DiagonalMatrix(array);
        }
    }
}
