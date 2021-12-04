using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    interface IAdminAccount
    {
        public void ShowClientBalance(BankAccount bankAccount);
        public double Rate { get; set; }
        public void BankTransaction(IClient clitntSeller, IClient clitntGetter, double money);
    }
}
