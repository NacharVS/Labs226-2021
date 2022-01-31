using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Shop
{
    class Product
    {
        public string nameOfProduct;
        public double price;
        public int countOfProduct;
        public string manufacturer;
        public string counterparty;

        public Product(string nameOfProduct, double price, int countOfProduct, string manufacturer, string conterparty)
        {
            this.nameOfProduct = nameOfProduct;
            this.price = price;
            this.countOfProduct = countOfProduct;
            this.manufacturer = manufacturer;
            this.counterparty = counterparty;
        }
    }
}