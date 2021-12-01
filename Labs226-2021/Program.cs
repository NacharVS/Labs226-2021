using Labs226_2021.Strategy;
using System;
using System.Threading;

namespace Labs226_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee account1 = new Employee("Ivan", 0, 1999);
            Client account2 = new Client("Kirill", 3000, 1999);
           

            account1.ShowInfo();
            account2.ShowInfo();
            account2.Deposit(account2 ,550);
            account1.Deposit(account2, 1500);
        }
    }
}
