using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class SberBank
    {
        public string name;
        public double balance;
        

        public static double rate = 0.007;
        public static double minWidtraw = 100;
        public static double maxWidtraw = 5000;
        public static double minDeposit = 10;
        public static double comissionForTransaction = 0.02;



        public SberBank(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{name} - {balance}");
        }

        public static void GetProfit(SberBank acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.balance += acc.balance * rate;
            }
        }

        public static void Deposit(double deposit, int month, SberBank acc)
        {
            for (int i = 0; i < month; i++)
            {
                deposit += deposit * 0.004;   
            }
            acc.balance += deposit;

        }

        public static void Withdraw(SberBank acc ,double money)
        {
            if (money > minWidtraw && money < maxWidtraw)
            {
                acc.balance -= money;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на балансе");
            }


        }

        public static void Transaction(SberBank accSeller, SberBank accGetter, double money)
        {
            if (accSeller.balance > money + (money * comissionForTransaction))
            {
                accSeller.balance -= money + money * comissionForTransaction;
                accGetter.balance += money;
            }
            else
            {
                Console.WriteLine("Ошибка транзакции");
            }
        }
    }
}
