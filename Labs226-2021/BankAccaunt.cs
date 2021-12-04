using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class BankAccount : IClient, IAdminAccount
    {
        private string _name;
        private double _balance;
        private int _id;
        private int _yearofBirth;
        private static double _rate = 0.007;
        private static double _minWidtraw = 100;
        private static double _maxWidtraw = 5000;
        private static double _minDeposit = 10;
        private static double _comissionForTransaction = 0.02;

        public string Name { get => _name; set => throw new System.NotImplementedException(); }
        public double Balance { get => _balance; set => _balance = value; }
        public double Rate { get => _rate; set => _rate = value; }
        public int Id { get => _id; set => throw new System.NotImplementedException(); }

        public BankAccount(string name, int id, double balance, int yezarofBirth)
        {
            this._name = name;
            this._id = id;
            this._balance = balance;
            this.Age = yezarofBirth;
        }
        public int Age
        {
            get
            {
                return _yearofBirth;
            }

            set
            {
                if (value > 1900 & value <= DateTime.Now.Year & DateTime.Now.Year - value >= 18)
                    _yearofBirth = DateTime.Now.Year - value;
                else
                {
                    Console.WriteLine("Введён неверный год" + " " + $" {Name}");
                }
            }
        }
        public void ShowInfo()
        {
            if (Age > 18)
                System.Console.WriteLine($"{Name} - {Balance} - {Age}");
            else
            {
                Console.WriteLine("Ваш возраст слишком мал");
            }
        }
        public void ShowClientBalance(BankAccount bankAccount)
        {
            System.Console.WriteLine($"Client: {bankAccount.Name} имеет {bankAccount.Balance} ");
        }
        public void GetProfit(int month)
        {
            {

                if (Age > 0)
                {
                    for (int i = 0; i < month; i++)
                    {
                        Balance += Balance * _rate;
                    }
                }
                else
                {
                    Console.WriteLine("Ваш ваозраст слишком мал");
                }

            }
        }

        public void Deposit(double money)
        {
            if (Age > 0)
            {
                if (money < _minDeposit)
                {
                    Console.WriteLine("Слишком маленькая сумма, минимальный депозит составляет 10");
                }
                else
                {
                    Balance = Balance + money;
                    Console.WriteLine($"На баланс {Name} было зачисленно {money}, теперь его баланс составляет {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Ваш ваозраст слишком мал");
            }

        }

        public void Withdraw(double money)
        {
            if (money < _minWidtraw)
            {
                Console.WriteLine($"Сумма, которую {Name} хочет снять, слишком мала, он может снять минимум {_minWidtraw} ");
            }
            else if (money > _maxWidtraw)
            {
                Console.WriteLine($"Сумма, которую {Name} хочет снять, слишком велика, за раз он может снять максимум {_maxWidtraw} ");
            }
            else
            {
                Balance = Balance - money;
                Console.WriteLine($"{Name} снял {money} и на его счету осталось {Balance}");
            }

        }

        public static void Transaction(IClient accSeller, IClient accGetter)
        {
            if (accSeller.Age > 0 & accGetter.Age > 0)
            {
                Console.WriteLine($"Введите сумму перевода");
                double p = double.Parse(Console.ReadLine());
                if (p < 0)
                {
                    Console.WriteLine("Недопустимое зачение");
                }
                else
                {
                    double k = (p * _comissionForTransaction) + p;
                    if (k > accSeller.Balance)
                    {
                        Console.WriteLine("На вашем счете недостаточно средств");
                    }
                    else
                    {
                        Console.WriteLine($"{accSeller.Name}, Вы хотите совершить перевод {accGetter.Name}?");
                        string o = Console.ReadLine();
                        if (o == "да")
                        {

                            accGetter.Balance = accGetter.Balance + p;
                            Console.WriteLine($"С учётом коммисии с вашего счета вычлось {k}");
                            accSeller.Balance = accSeller.Balance - k;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Ваш ваозраст слишком мал");
            }
        }
        public static void BankTransaction(IClient id, IClient id2)
        {
                Console.WriteLine($"Введите сумму перевода");
                double p = double.Parse(Console.ReadLine());
                if (p < 0)
                {
                    Console.WriteLine("Недопустимое зачение");
                }
                else
                {
                    double k = (p * _comissionForTransaction) + p;
                    if (k > id.Balance)
                    {
                        Console.WriteLine("На вашем счете недостаточно средств");
                    }
                    else
                    {
                        Console.WriteLine($"{id.Name}, Вы хотите совершить перевод {id2.Name}?");
                        string o = Console.ReadLine();
                        if (o == "да")
                        {

                            id2.Balance = id2.Balance + p;
                            Console.WriteLine($"С учётом коммисии с вашего счета вычлось {k}");
                            id.Balance = id.Balance - k;
                        }
                    }
                }
        }
    }
}
