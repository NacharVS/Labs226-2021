using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    interface IBankAdmin
    {
        public void ShowClientBalance(BankAccount bankAccount);
        public double Rate { get; set; }
    }
}
