using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Ivan", 1000);
            acc1.BalanceChangedEvent += ShowMessage;
            acc1.Balance = 600;

            

        }

        static void ShowMessage(double balance, double old, double diff)
        {
            Console.WriteLine($"Balance has changed! Old Balance {old} Current balance {balance}. Difference {diff}");
        }
    }
}
