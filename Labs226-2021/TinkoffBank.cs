using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class TinkoffBank
    {
        private int age;
        private int yearOfBirth;
        private string name;
        private double balance;

        private static double rate = 0.007;
        private static double minWidtraw = 100;
        private static double maxWidtraw = 5000;
        private static double minDeposit = 100;
        private static double comissionForTransaction = 0.02;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value;}
        public double Balance { get => balance; set => balance = value; }


        public double Rate { get => rate; set => rate = value; }
        public double MinWidtraw { get => minWidtraw; set => minWidtraw = value; }
        public double MaxWidtraw { get => maxWidtraw; set => maxWidtraw = value; }
        public double MinDeposit { get => minDeposit; set => minDeposit = value; }
        public double ComissionForTransaction { get => comissionForTransaction; set => comissionForTransaction = value; }


        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }

            set
            {
                if (value < 1900 || value >= DateTime.Now.Year)
                {
                    Console.WriteLine("Вы ввели неверный год рождения");
                    Age = 0;
                }
                else
                {
                    Age = DateTime.Now.Year - value;
                    Console.WriteLine($"Ваш возраст - {Age}");
                }
            }
        }



        public TinkoffBank(string name, double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{Name} - {Balance}");
        }

        public static void GetProfit(TinkoffBank acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.Balance += acc.Balance * acc.Rate;
            }
        }

        public static void Deposit(double deposit, int month, TinkoffBank acc)
        {
            if (deposit > minDeposit)
            {
                for (int i = 0; i < month; i++)
                {

                    deposit += deposit * 0.004;
                }
                acc.Balance += deposit;
            }
            else
            {
                Console.WriteLine("Минимальный депозит - 100");
            }


        }

        public static void Withdraw(TinkoffBank acc, double money)
        {
            if (money > acc.MinWidtraw && money < acc.MaxWidtraw)
            {
                acc.Balance -= money;

            }
            else if (money <= acc.MinWidtraw)
            {
                Console.WriteLine("Минимальный вывод - 10");
            }
            else if (money >= acc.MaxWidtraw)
            {
                Console.WriteLine("Максимальный вывод - 5000");
            }


        }



        public static void Transaction(TinkoffBank accSeller, TinkoffBank accGetter, double money)
        {
            if (accSeller.Balance > money + (money * comissionForTransaction))
            {
                accSeller.Balance -= money + money * comissionForTransaction;
                accGetter.Balance += money;
            }
            else
            {
                Console.WriteLine("Ошибка транзакции");
            }
        }
    }
}
