using System;
using System.Threading;

namespace ConsoleApp7

{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Махмут Еврееич", 3000, 43);
            BankAccount account2 = new BankAccount("Игорь Корявый", 100000, 20);

            account1.ShowInfo();
            account2.ShowInfo();
            BankAccount.GetProfit(account1, 2);
            BankAccount.GetProfit(account2, 2);
            account1.ShowInfo();
            account2.ShowInfo();
            BankAccount.Withdraw(account1, 100);
            BankAccount.Deposit(account2, 5000);
            BankAccount.Transaction(account1, account2);
            account1.ShowInfo();
            account2.ShowInfo();
        }
    }
    class BankAccount
    {
        public string name;
        public double balance;
        public int age;
        public static double rate = 0.01;
        public static double minWidtraw = 100;
        public static double maxWidtraw = 5000;
        public static double minDeposit = 10;
        public static double comissionForTransaction = 0.05;



        public BankAccount(string name, double balance, int age)
        {
            this.name = name;
            this.balance = balance;
            this.age = age;
        }
        public void ShowInfo()
        {
            if (age > 18)
                System.Console.WriteLine($"{name} - {balance} - {age} годииков");
            else
            {
                Console.WriteLine("Мал да удал");


            }
        }

        public static void GetProfit(BankAccount acc, int month)
        {
            {

                if (acc.age > 18)
                {
                    for (int i = 0; i < month; i++)
                    {
                        acc.balance += acc.balance * rate;
                    }
                }
                else
                {
                    Console.WriteLine("Ты маленький, иди повзрослей");
                }

            }
        }

        public static void Deposit(BankAccount acc, double money)
        {
            if (acc.age > 18)
            {
                if (money < minDeposit)
                {
                    Console.WriteLine("Минимальный депозит составляет 10");
                }
                else
                {
                    acc.balance = acc.balance + money;
                    Console.WriteLine($"На ваш баланс {acc.name} было зачисленно - {money}, теперь ваш баланс составляет - {acc.balance}");
                }
            }
            else
            {
                Console.WriteLine("Ты маленький, иди повзрослей");
            }

        }

        public static void Withdraw(BankAccount acc, double money)
        {
            if (money < minWidtraw)
            {
                Console.WriteLine($"Сумма, которую {acc.name} хочет вывести, слишком мала, можно вывести минимум {minWidtraw} ");
            }
            else if (money > maxWidtraw)
            {
                Console.WriteLine($"Сумма, которую {acc.name} хочет вывести, слишком велика, за раз он может вывести только {maxWidtraw} ");
            }
            else
            {
                acc.balance = acc.balance - money;
                Console.WriteLine($"{acc.name} снял {money} на счету осталось {acc.balance}");
            }

        }

        public static void Transaction(BankAccount accSeller, BankAccount accGetter)
        {
            if (accSeller.age > 18 & accGetter.age > 18)
            {
                Console.WriteLine($"Введите сколько хотите перевести");
                double p = double.Parse(Console.ReadLine());

                double k = (p * comissionForTransaction) + p;
                if (k > accSeller.balance)
                {
                    Console.WriteLine("Денег нет, но вы держитесь");
                }
                else
                {
                    Console.WriteLine($"{accSeller.name}, Вы хотите совершить перевод {accGetter.name}?");
                    string o = Console.ReadLine();
                    if (o == "да")
                    {

                        accGetter.balance = accGetter.balance + p;
                        Console.WriteLine($"С учётом коммисии с вашего счета вычлось {k}");
                        accSeller.balance = accSeller.balance - k;
                    }
                }

            }
            else
            {
                Console.WriteLine("Ты маленький, иди повзрослей");
            }
        }
    }

}