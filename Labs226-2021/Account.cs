using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Account
    {
        static public void TinkoffBank()
        {
            TinkoffBank account1 = new TinkoffBank("Marina", 14000);
            TinkoffBank account2 = new TinkoffBank("Aigul", 12000);
            TinkoffBank account3 = new TinkoffBank("Hazbik:)", 17000);


            account1.YearOfBirth = 2006;
            account2.YearOfBirth = 2005;
            account3.YearOfBirth = 2001;



            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            Console.WriteLine();

            Labs226_2021.TinkoffBank.GetProfit(account1, 6);
            Labs226_2021.TinkoffBank.GetProfit(account2, 6);
            Labs226_2021.TinkoffBank.GetProfit(account3, 6);

            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            Console.WriteLine();

            account1.ShowInfo();
            Labs226_2021.TinkoffBank.Deposit(9, 6, account1);
            account2.ShowInfo();
            Labs226_2021.TinkoffBank.Deposit(2000, 6, account2);
            account3.ShowInfo();
            Labs226_2021.TinkoffBank.Deposit(2000, 6, account3);
            Console.WriteLine();

            account1.ShowInfo();
            Labs226_2021.TinkoffBank.Withdraw(account1, 99);
            account2.ShowInfo();
            Labs226_2021.TinkoffBank.Withdraw(account2, 10000);
            account3.ShowInfo();
            Labs226_2021.TinkoffBank.Withdraw(account3, 1000);
    
            
            Console.WriteLine();

            Labs226_2021.TinkoffBank.Transaction(account1, account2, 5000);

            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            Console.WriteLine();

        }
    }
}
