//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Labs226_2021.Bank
//{
//    class Client : SberBank
//    {
//        public Client(string name, string surname, double balance) : base(name, surname, balance)
//        {
//        }

//        public override void Withdraw(SberBank acc, double money)
//        {
//            if (money > acc.MinWidtraw && money < acc.MaxWidtraw)
//            {

//                acc.Balance -= money;
//                Console.WriteLine($"{acc.Name} снять деньги на счёт");

//            }
//            else if (money <= acc.MinWidtraw)
//            {
//                Console.WriteLine("Минимальная сумма зачисления - 100");
//            }
//            else if (money >= acc.MaxWidtraw)
//            {
//                Console.WriteLine("Максимальная сумма зачисления  - 500000");
//            }
//        }

//        public override void ToDeposit(SberBank acc, double money)
//        {
//            if (money > acc.MinWidtraw && money < acc.MaxWidtraw)
//            {

//                acc.Balance += money;
//                Console.WriteLine($"{acc.Name} положил деньги на счёт");

//            }
//            else if (money <= acc.MinWidtraw)
//            {
//                Console.WriteLine("Минимальная сумма зачисления - 100");
//            }
//            else if (money >= acc.MaxWidtraw)
//            {
//                Console.WriteLine("Максимальная сумма зачисления  - 500000");
//            }
//        }

//        public override void Transaction(SberBank accSeller, SberBank accGetter, double money)
//        {
//            if (accSeller.Balance > money + (money * ComissionForTransaction))
//            {
//                accSeller.Balance -= money + money * ComissionForTransaction;
//                accGetter.Balance += money;
//            }
//            else
//            {
//                Console.WriteLine("Ошибка транзакции");
//            }
//        }





//    }
//}
