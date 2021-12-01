using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Account
    {
        static public void Sber()
        {
            Client account1 = new Client("Ivan", "Ivanov" , 15000);
            Client account2 = new Client("Kirill", "Losev" , 13000);
            Client account3 = new Client("Elena", "Elenova" , 16000);
            Employee emp = new Employee("Timur", "Balon", 0);
            Security sec = new Security("Dyadya Volodya", "Petrov", 10);
            emp.GoToBank();
            account1.GoToBank();




            //account1.YearOfBirth = 2005;
            //account2.YearOfBirth = 2004;
            //account3.YearOfBirth = 2002;

            account1.ShowInfo();
            Console.WriteLine();

            emp.Withdraw(account1, 1000);
            account1.ShowInfo();
            Console.WriteLine();

            emp.ToDeposit(account2, 4000);
            account2.ShowInfo();
            Console.WriteLine();

            account3.ToDeposit(account3, 2000);
            account3.ShowInfo();
            Console.WriteLine();


            sec.Sit(sec);



        }
    }
}
