using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Account
    {
        static public void Sber()
        {
            AccountBank account1 = new SberBank("Ivan", 15000);
            AccountBank account2 = new SberBank("Kirill", 13000);
            AccountBank account3 = new SberBank("Elena", 16000);


            account1.YearOfBirth = 2003;
            account2.YearOfBirth = 2002;
            account3.YearOfBirth = 2002;



            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            Console.WriteLine();

            SberBank.GetProfit(account1, 6);
            SberBank.GetProfit(account2, 6);
            SberBank.GetProfit(account3, 6);

            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            Console.WriteLine();

            account1.ShowInfo();
            AccountBank.Deposit(9, 6, account1);
            account2.ShowInfo();
            AccountBank.Deposit(2000, 6, account2);
            account3.ShowInfo();
            AccountBank.Deposit(2000, 6, account3);
            Console.WriteLine();

            account1.ShowInfo();
            AccountBank.Withdraw(account1, 99);
            account2.ShowInfo();
            AccountBank.Withdraw(account2, 10000);
            account3.ShowInfo();
            AccountBank.Withdraw(account3, 1000);


            Console.WriteLine();

            Account.Transaction(account1, account2, 5000);

            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            Console.WriteLine();

        }
    }
}