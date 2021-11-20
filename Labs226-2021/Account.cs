using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Account
    {
        static public void Sber()
        {
            SberBank account1 = new SberBank("Ivan", 5000);
            SberBank account2 = new SberBank("Kirill", 3000);
            SberBank account3 = new SberBank("Elena", 6000);

            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();

            SberBank.GetProfit(account1, 6);
            SberBank.GetProfit(account2, 6);
            SberBank.GetProfit(account3, 6);
            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();
            SberBank.Deposit(2000, 6, account2);

            account1.ShowInfo();
            SberBank.Withdraw(account3, 1000);
            account1.ShowInfo();
            SberBank.Transaction(account1, account2, 5000);
            account1.ShowInfo();
            account2.ShowInfo();
            account3.ShowInfo();

        }
    }
}
