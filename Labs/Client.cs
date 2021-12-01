using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Client : BankAccount
    {
        public Client(string name, double balance, int yearofBirth) : base(name, balance, yearofBirth)
        {

        }
        public override void Deposit(Client acc , double money)
        {
            if (Age > 0)
            {
                if (money < maxDeposit & money > minDeposit)
                {
                    Console.WriteLine($"Клиент {name} пришёл пополнить счёт в Банк");
                    balance += money;
                    Console.WriteLine($"Счёт пополнен на {money}");
                    ShowInfo();

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
    }
}
