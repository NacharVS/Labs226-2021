using System;

namespace Labs226_2021
{
    class BankAccount
    {
        public string name;
        public double balance;
        private int _yearofBirth;
        public static double rate = 0.007;
        public static double minWidtraw = 100;
        public static double maxWidtraw = 5000;
        public static double minDeposit = 10;
        public static double maxDeposit = 10000;

       
        public static double comissionForTransaction = 0.02;



        public BankAccount(string name, double balance,int yearofBirth)
        {
            this.name = name;
            this.balance = balance;
            this.Age = yearofBirth;
        }

        public void ShowInfo()

        {
           if(Age > 0 )
            System.Console.WriteLine($"{name} - {balance} - {Age}");
            else
            {
                Console.WriteLine("Заблокиравано");
            }
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
                    Console.WriteLine("Введён неверный год"+ " " + $" { name}");
                }
            }
        }

        public static void GetProfit(BankAccount acc, int month)
        {
            
            if (acc.Age > 0)
            {
                for (int i = 0; i < month; i++)
                {
                    acc.balance += acc.balance * rate;
                }
            }
            else
            {
                Console.WriteLine("Заблокиравано");
            }

        }
        public virtual void Deposit(Client acc , double money)

        {
            if (Age > 0)
            {
                if (money < maxDeposit & money > minDeposit)
                {
                    balance += money;
                }
                else
                {
                    System.Console.WriteLine("Лимит по депозиту");
                }
            }
            else
            {
                Console.WriteLine("Заблокировано");
            }
        }

        public void Withdraw(double money)
        {
            if (Age > 0)
            {
                if (money > minWidtraw)
                {
                    if (money < maxWidtraw)
                    {
                        if (money < balance)
                        {
                            balance -= money;
                        }
                        else
                        {
                            System.Console.WriteLine("Мало денег на балансе");
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Мало денег на балансе");
                    }
                }
                else
                {
                    System.Console.WriteLine("Мало денег на балансе");
                }
            }
            else
            {
                Console.WriteLine("Заблокиравано");
            }
        }

        public static void Transaction(BankAccount accSeller, BankAccount accGetter , double money)
        {
            if (accSeller.Age > 0 & accGetter.Age > 0)
            {
                if (accSeller.balance > money + (money * comissionForTransaction))
                {
                    accSeller.balance -= money + money * comissionForTransaction;
                    accGetter.balance += money;
                }
                else
                {
                    System.Console.WriteLine("Недостаточно средств");
                }
            }
            else
            {
                Console.WriteLine("Заблокиравано");
            }
        }
    }
}
