using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Shop
{
    class Product
    {
        public string name;
        public double price;
        public int number;
        public string nameCreator;

        
        public Product(string name, double price, int number, string nameCreator)
        {
            this.name = name;
            this.price = price;
            this.number = number;
            this.nameCreator = nameCreator;

        }

       public void SubNum()
        {
            int storage = int.Parse(Console.ReadLine());
            number -= storage;

        }
        public void ShowInfo()
        {
           
        }
    }
}
