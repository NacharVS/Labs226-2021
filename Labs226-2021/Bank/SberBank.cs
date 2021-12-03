using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Bank
{
    class SberBank : IClient, IEmployee
    {
        private int _age;
        private int _yearOfBirth;
        private int _id;
        private string _name;
        private string _surname;
        private double _balance;

        private static double _rate = 0.007;
        private static double _minWidtraw = 100;
        private static double _maxWidtraw = 5000;
        private static double _minDeposit = 100;
        private static double _comissionForTransaction = 0.02;

        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value;}
        public string Surname { get => _surname; set => _surname = value; }
        public double Balance { get => _balance; set => _balance = value; }
        public int Id { get => _id; set => _id = value; }


        public double Rate { get => _rate; set => _rate = value; }
        public double MinWidtraw { get => _minWidtraw; set => _minWidtraw = value; }
        public double MaxWidtraw { get => _maxWidtraw; set => _maxWidtraw = value; }
        public double MinDeposit { get => _minDeposit; set => _minDeposit = value; }
        public double ComissionForTransaction { get => _comissionForTransaction; set => _comissionForTransaction = value; }


        public int YearOfBirth
        {
            get
            {
                return _yearOfBirth;
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



        public SberBank(string Name, double Balance, int Id)
        {
            this._name = Name;
            this._balance = Balance;
            this._id = Id;
        }

        public void GoToBank()
        {
            Console.WriteLine($"{Name} goes to Bank");
        }



        

        public void Showinfo()
        {
            Console.WriteLine($"{Name} - {Balance}");
        }

        public void Withdraw(double money)
        {
            if (money > MinWidtraw && money < MaxWidtraw)
            {

                Balance -= money;

            }
            else if (money <= MinWidtraw)
            {
                Console.WriteLine("Минимальный вывод - 100");
            }
            else if (money >= MaxWidtraw)
            {
                Console.WriteLine("Максимальный вывод - 5000");
            }

        }

        public void GetProfit(int month)
        {
            for (int i = 0; i < month; i++)
            {
                Balance += Balance * Rate;
            }
        }

        public void Deposit(double money, int month)
        {
            if (money > _minDeposit)
            {
                for (int i = 0; i < month; i++)
                {

                    money += money * 0.004;
                }
                Balance += money;
            }
            else
            {
                Console.WriteLine("Минимальный депозит - 100");
            }
        }

        public void ToDeposit(double money)
        {
            if (money > _minWidtraw && money < _maxWidtraw)
            {

                Balance += money;

            }
            else if (money <= _minWidtraw)
            {
                Console.WriteLine("Минимальная сумма зачисления - 100");
            }
            else if (money >= _maxWidtraw)
            {
                Console.WriteLine("Максимальная сумма зачисления  - 500000");
            }
        }


        public void Transaction(SberBank Recipient, double money)
        {
            if (Balance > money + (money * _comissionForTransaction))
            {
                Balance -= money + money * _comissionForTransaction;
                Recipient.Balance += money;
            }
            else
            {
                Console.WriteLine("Ошибка транзакции");
            }
        }

        public void AdminTransaction(SberBank ToSend, SberBank Recipient, double money)
        {
            if (ToSend.Balance > money + (money * _comissionForTransaction))
            {
                ToSend.Balance -= money + money * _comissionForTransaction;
                Recipient.Balance += money;
            }
            else
            {
                Console.WriteLine("Ошибка транзакции");
                Console.WriteLine($"У клиента {ToSend.Name} недостаточно средств на балансе");
            }
        }
    }
}
