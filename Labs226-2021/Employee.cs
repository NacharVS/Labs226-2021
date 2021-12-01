using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Employee : SberBank
    {
        public Employee(string name, string surname, double balance) : base(name, surname, balance)
        {

        }


        public override void Withdraw(SberBank acc, double money)
        {
            
            if (money > acc.MinWidtraw && money < acc.MaxWidtraw)
            {

                acc.Balance -= money;
                Console.WriteLine($"Сотрудник вывел деньги со счёта '{acc.Name}'");
            }
            else if (money <= acc.MinWidtraw)
            {
                Console.WriteLine("Минимальный вывод - 100");
            }
            else if (money >= acc.MaxWidtraw)
            {
                Console.WriteLine("Максимальный вывод - 5000");
            }
        }



        public override void ToDeposit(SberBank acc, double money)
        {
            if (money > acc.MinWidtraw && money < acc.MaxWidtraw)
            {

                acc.Balance += money;
                Console.WriteLine($"Сотрудник положил деньги на счёт '{acc.Name}'");


            }
            else if (money <= acc.MinWidtraw)
            {
                Console.WriteLine("Минимальная сумма зачисления - 100");
            }
            else if (money >= acc.MaxWidtraw)
            {
                Console.WriteLine("Максимальная сумма зачисления  - 500000");
            }
        }

        public override void GoToBank()
        {
            Console.WriteLine($"{Name} goes to Bank");
        }



    }
}
