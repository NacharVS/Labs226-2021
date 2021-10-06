using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] array = new int[8, 8];
            Method.ArrayGeneration(array, n);
        }
    }
}
