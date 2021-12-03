using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Bank
{
    class Account
    {
        static public void Sber()
        {
            SberBank client1 = new SberBank("Anton", 2000, 1233);
            SberBank client2 = new SberBank("Timur", 3000, 2324);
            SberBank client3 = new SberBank("Ildar", 5000, 4324);
            SberBank employee1 = new SberBank("Dinar", 200, 4323);

            IClient cl1 = client1;
            IClient cl2 = client2;
            IClient cl3 = client3;
            IEmployee emp1 = employee1;

            int[] IdClient = new int[3];
            IdClient[0] = client1.Id;
            IdClient[1] = client2.Id;
            IdClient[2] = client3.Id;


            cl1.Showinfo();
            cl1.Withdraw(1000);
            cl1.Showinfo();

            cl1.GetProfit(6);
            cl1.Showinfo();

            cl1.Transaction(client2, 1000);

            cl1.Showinfo();
            cl2.Showinfo();

            emp1.AdminTransaction(client2, client1, 2000);

            cl1.Showinfo();
            cl2.Showinfo();








        }
    }
}
