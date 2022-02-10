using Labs226_2021.Interfaces;
using Labs226_2021.MongoExamples;
using Labs226_2021.Shop;
using Labs226_2021.Strategy;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoExtensions.AddToDataBase(new User("Ivan", 50));




        }

        //static void ShowMessage(double balance, double old, double diff)
        //{
        //    Console.WriteLine($"Balance has changed! Old Balance {old} Current balance {balance}. Difference {diff}");
        //}
    }
}
