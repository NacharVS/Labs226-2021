using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    interface IBankClient
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public void ShowInfo();
    }
}
