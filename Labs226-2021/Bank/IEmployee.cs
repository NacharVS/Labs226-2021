using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Bank
{
    interface IEmployee
    {

        public void AdminTransaction(SberBank ToSend, SberBank Recipient, double money);
        
    }
}
