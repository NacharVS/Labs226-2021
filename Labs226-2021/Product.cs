using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Product
    {
        public string name;
        public double prise;
        public int qouter;

        public Product(string name, double prise, int qouter)
        {
            this.name = name;
            this.prise = prise;
            this.qouter = qouter;
        }
    }
}
