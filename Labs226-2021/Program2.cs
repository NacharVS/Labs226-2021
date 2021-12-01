using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Andrey", 50000, 1990);
            BankAccount account2 = new BankAccount("Vildan", 3000, 1980);
            BankAccount account3 = new BankAccount("Vlad", 6000, 2000);

            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            BankAccount.rate = 0.004;
            BankAccount.GetProfit(account1, 6);
            BankAccount.GetProfit(account2, 6);
            BankAccount.GetProfit(account3, 6);
            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            account1.Deposit(6);

            account1.ShowInfo();
            account1.Withdraw(9);
            account1.ShowInfo();
            BankAccount.Transaction(account1, account2, 5000);
            account1.ShowInfo();
            account2.ShowInfo();
        }
    }
}
