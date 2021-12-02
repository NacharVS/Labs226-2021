using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    interface IBankClient
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public int Id { get; set; }

        public void ShowInfo();
        public void Deposid(double money);
        public void Withdraw(double money);
        public void Trade(IBankClient clitntSeller, IBankClient clitntGetter, double money);
        public void GetProfit(int month );
    }
}
