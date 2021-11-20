using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankOper
{
   
    class MainAF
    { 
        static BankAccount[] accounts = new BankAccount[3];
        public static void Main(string[] args)
        {
            accounts[0] = new BankAccount("Ivan", 5000);
            accounts[1] = new BankAccount("Kirill", 3000);
            accounts[2] = new BankAccount("Elena", 6000);
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

        public void Deposit(double money)
        {
          Console.WriteLine("Введите сумму пополнения, она должна быть не меньше 100");
            money = Convert.ToDouble(Console.ReadLine());
            if (money >= minDeposit) 
            {
               balance = (balance + money);
            }
            else
            {
                Console.WriteLine("Сумма депозита слишком мала");
            }
        }

        public void Withdraw(double money)
        {
            Console.WriteLine("Введите сумму списания, она должна быть не меньше 100 и не больше 5000");
            money = Convert.ToDouble(Console.ReadLine());
            if (money >= minWidtraw && money <= maxWidtraw && money - maxWidtraw != 0)
            {
                balance = balance - money;
            }
            else
            {
                Console.WriteLine("Не выполнены условия списания");
            }
        }

        public static void Transaction ()
        {
                Console.WriteLine("Кто отправитель");
                string anss = Console.ReadLine();
                BankAccount accSeller = null;
                foreach (BankAccount i in accounts)
                {
                    if (i.name == anss) 
                    {
                        accSeller = i;
                    }
                }
                if (accSeller == null) 
                {
                    return;
                }
                Console.WriteLine("Кто Получатель");
                anss = Console.ReadLine();
                BankAccount accGetter = null;
                foreach (BankAccount i in accounts)
                {
                    if (i.name == anss)
                    {
                        accGetter = i;
                    }
                    if (accGetter == null) 
                    {
                        return;
                    }
                }
                Console.WriteLine("Введите сумму перевода");
                double sum = Convert.ToDouble(Console.ReadLine());
                double comm = sum * comissionForTransaction;
                Console.WriteLine("Комиссия будет составлять " + comm +" Рублей");
                sum = sum - comm;
                if (accSeller.balance - sum > 0)
                {
                    accGetter.balance += sum;
                    accSeller.balance -= sum;
                }
                else 
                {
                    Console.WriteLine("Недостаточно средств для перевода");
                }
            }
    }

    }
    
}