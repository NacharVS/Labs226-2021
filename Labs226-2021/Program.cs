using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankClient client1 = new BankAccount("Fedor",1 , 2000);
            IBankClient client2 = new BankAccount("Rad", 2, 900);
            IBankAdmin admin = new BankAccount("Anton", 0 ,8.79);
            client1.ShowInfo();
            client1.Trade(client1, client2, 1000);
            admin.BankTrade( client1, client2 ,500);

        }
    }
}
