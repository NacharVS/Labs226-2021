using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Bank
{
    interface IClient
    {


        public void Showinfo();
        public void Withdraw(double money);
        public void GetProfit(int month);
        public void Deposit(double money, int month);
        public void ToDeposit(double money);
        public void Transaction(SberBank Recipient, double money);
    }
}
