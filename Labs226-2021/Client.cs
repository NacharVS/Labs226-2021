using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    interface IClient
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public void ShowInfo();
        public void Deposit(double money);
        public void Withdraw(double money);
        public void Transaction(IClient clitntSeller, IClient clitntGetter);
        public void GetProfit(int month);
    }
}