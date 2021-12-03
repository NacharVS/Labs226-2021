using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Bank
{
    class Security : SberBank
    {
        public Security(string name, string surname, double balance) : base(name, surname, balance)
        {
        }

        public void Sit(SberBank acc)
        {
            Console.WriteLine($"{acc.Name} cледит за порядком");
        }

        
    }
}
