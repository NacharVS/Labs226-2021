using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int div = 2;
            while(num > 1 || num < -1)
            {
                if (num % div == 0)
                {
                    num /= 2;
                    Console.WriteLine(div);
                }
                else
                    div++;
            }




        }
    }
}
