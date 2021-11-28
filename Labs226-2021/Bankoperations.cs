using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankOper
{
   
    class MainAF
    {
        
        class BankAccount
        {

            
            public string name;
            public double balance;
            private int _YearOfBirth;
            public static double rate = 0.007;
            public static double minWidtraw = 100;
            public static double maxWidtraw = 5000;
            public static double minDeposit = 10;
            public static double maxDeposit = 10000;


            public static double comissionForTransaction = 0.02;



            public BankAccount(string name, double balance, int YearOfBirth)
            {
                this.name = name;
                this.balance = balance;
                this.Age = YearOfBirth;
            }

            public void ShowInfo()

            {
                if (Age > 0)
                    System.Console.WriteLine($"{name} - {balance} - {Age}");
                else
                {
                    Console.WriteLine("Доступ запрещён");
                }
            }
            public int Age
            {
                get
                {
                    return _YearOfBirth;
                }

                set
                {
                    if (value > 1900 & value <= DateTime.Now.Year & DateTime.Now.Year - value >= 18)
                        _YearOfBirth = DateTime.Now.Year - value;
                    else
                    {
                        Console.WriteLine("Введён неверный год " + $" { name}");
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
                    Console.WriteLine("Доступ Запрещён");
                }

            }
            public void Deposit(double money)

            {
                if (Age > 0)
                {
                    if (money < maxDeposit && money > minDeposit)
                    {
                        balance += money;
                    }
                    else
                    {
                        System.Console.WriteLine("нарушены лимиты депозита");
                    }
                }
                else
                {
                    Console.WriteLine("Доступ Запрещён");
                }
            }

            public void Withdraw(double money)
            {
                if (Age > 0 && money > minWidtraw && money < maxWidtraw && money < balance)
                {
                    balance -= money;
                }
                else 
                {
                    Console.WriteLine("Не выполнены условия");
                }
                   
                          
            }

            public static void Transaction(BankAccount accSeller, BankAccount accGetter, double money)
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
                    Console.WriteLine("Доступ Запрещён");
                }
            }
        }







    }
    
}