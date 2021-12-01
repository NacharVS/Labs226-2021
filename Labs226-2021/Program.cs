using System;
using System.Threading;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Зийатдинав Болат", 20000, 35);
            BankAccount account2 = new BankAccount("Гуйнитдинав Олан", 13000, 19);

            account1.ShowInfo();
            account2.ShowInfo();
            BankAccount.GetProfit(account1, 10);
            BankAccount.GetProfit(account2, 10);
            account1.ShowInfo();
            account2.ShowInfo();
            BankAccount.Withdraw(account1, 200);//сумма пополнения
            BankAccount.Deposit(account2, 2000);//сумма вывода
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
        public static double rate = 0.007;
        public static double minWidtraw = 100;
        public static double maxWidtraw = 5000;
        public static double minDeposit = 10;
        public static double comissionForTransaction = 0.02;



        public BankAccount(string name, double balance, int age)
        {
            this.name = name;
            this.balance = balance;
            this.age = age;
        }
        public void ShowInfo()
        {
            if (age > 18)
                System.Console.WriteLine($"{name} - {balance} - {age} лет");
            else
            {
                Console.WriteLine("Вы несовершеннолетний");
            }
        }

        public static void GetProfit(BankAccount acc, int month)
        {
            {

                if (acc.age > 0)
                {
                    for (int i = 0; i < month; i++)
                    {
                        acc.balance += acc.balance * rate;
                    }
                }
                else
                {
                    Console.WriteLine("Вы несовершеннолетний");
                }

            }
        }

        public static void Deposit(BankAccount acc, double money)
        {
            if (acc.age > 0)
            {
                if (money < minDeposit)
                {
                    Console.WriteLine("Минимальный депозит составляет 10");
                }
                else
                {
                    acc.balance = acc.balance + money;
                    Console.WriteLine($"На баланс {acc.name} было зачисленно - {money}, теперь его баланс составляет - {acc.balance}");
                }
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний");
            }

        }

        public static void Withdraw(BankAccount acc, double money)
        {
            if (money < minWidtraw)
            {
                Console.WriteLine($"Сумма, которую {acc.name} хочет снять, слишком мала, можно снять минимум {minWidtraw} ");
            }
            else if (money > maxWidtraw)
            {
                Console.WriteLine($"Сумма, которую {acc.name} хочет снять, слишком велика, за один раз он может снять только {maxWidtraw} ");
            }
            else
            {
                acc.balance = acc.balance - money;
                Console.WriteLine($"{acc.name} снял {money} на счету осталось {acc.balance}");
            }

        }

        public static void Transaction(BankAccount accSeller, BankAccount accGetter)
        {
            if (accSeller.age > 0 & accGetter.age > 0)
            {
                Console.WriteLine($"Введите сколько хотите перевести");
                double p = double.Parse(Console.ReadLine());

                double k = (p * comissionForTransaction) + p;
                if (k > accSeller.balance)
                {
                    Console.WriteLine("На вашем счете недостаточно средств");
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
                Console.WriteLine("Вы несовершеннолетний");
            }
        }
    }

}