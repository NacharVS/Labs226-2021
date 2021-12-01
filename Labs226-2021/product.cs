using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Product
    {
        public string nameOfProduct;
        public double price;
        public double quantity;

        public Product(string nameOfProduct, double price, double quantity)
        {
            this.nameOfProduct = nameOfProduct;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
