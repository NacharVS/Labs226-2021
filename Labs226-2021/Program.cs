using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankClient client1 = new BankAccount("Fedor", 2000);
            IBankAdmin admin = new BankAccount("Anton", 8.79);
            

        }
    }
}
