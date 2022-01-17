using System;
using System.Collections.Generic;


namespace ConsoleApp25
{
    class Product
    {
        public string nameOfProduct;
        public double price;
        public int countOfProduct;
        public string manufacturer;
        public string counteragent;

        public Product(string nameOfProduct, double price, int countOfProduct, string manufacturer, string counteragentparam)     
        {
            this.nameOfProduct = nameOfProduct;
            this.price = price;
            this.countOfProduct = countOfProduct;
            this.manufacturer = manufacturer;
           counteragent = counteragentparam;

        }
    }
    class Programm
    {
        static void Main(string[] args)
        {

            Product pen = new Product("pen", 40, 10000, "China", "Magnit");
            Product pencil = new Product("pencil", 20, 1000, "Russia","Magnit");
            Product airpods = new Product("airpods", 20000, 1990, "USA","Aliexspress");
            Product pod = new Product("pod", 1200, 1000, "China","Smokeshop");
            Product book = new Product("book", 1000000, 1000, "Italy","Freedoom");
            Product chair = new Product("chair", 600, 900, "China","Kazanexspress");
            Product armchair = new Product("armchair", 1240, 8000, "China","Wildberies");
            Product sofa = new Product("sofa", 4000, 700, "China","Ozon");
            Product boots = new Product("boots", 4950, 1000, "China","Bershka");
            Product backpack = new Product("backpack", 40000, 100, "China","Shein");





        }
    }

}
