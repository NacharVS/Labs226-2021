using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Ivan", 5000);
            BankAccount account2 = new BankAccount("Kirill", 3000);

            account1.ShowInfo();
            account2.ShowInfo();
            BankAccount.rate = 0.01;
            BankAccount.GetProfit(account1, 10);
            BankAccount.GetProfit(account2, 10);
            account1.ShowInfo();
            account2.ShowInfo();
            BankAccount.Withdraw(account1, 20000);

        }
    }
    class BankAccount
    {
        public string name;
        public double balance;

        public static double rate = 0.007;
        public static double minWidtraw = 100;
        public static double maxWidtraw = 5000;
        public static double minDeposit = 10;
        public static double comissionForTransaction = 0.02;



        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{name} - {balance}");
        }

        public static void GetProfit(BankAccount acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.balance += acc.balance * rate;
            }
        }

        public void Deposit(BankAccount acc, double money)
        {
            if (money < minDeposit)
            {
                Console.WriteLine("Слишком маленькая сумма, минимальный депозит составляет 10");
            }
            else
            {
                acc.balance = acc.balance + money;
                Console.WriteLine($"На баланс {acc.name} было зачисленно {money}, теперь его баланс составляет {acc.balance}");
            }

        }

        public static void Withdraw(BankAccount acc, double money)
        {
            if (money < minWidtraw)
            {
                Console.WriteLine($"Сумма, которую {acc.name} хочет снять, слишком мала, он может снять минимум {minWidtraw} ");
            }
            else if (money > maxWidtraw)
            {
                Console.WriteLine($"Сумма, которую {acc.name} хочет снять, слишком велика, за раз он может снять максимум {maxWidtraw} ");
            }
            else
            {
                acc.balance = acc.balance - money;
                Console.WriteLine($"{acc.name} снял {money} и на его счету осталось {acc.balance}");
            }
        }

        public static void Transaction(BankAccount accSeller, BankAccount accGetter)
        {

        }
    }

}
