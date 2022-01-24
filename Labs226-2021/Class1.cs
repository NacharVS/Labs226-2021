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



        //public void SubNum()
        //{
        //    int storage =buck ;
        //    number -= storage;

        //}
        public void ShowInfo()
        {
           
        }
        public void Bucket()
        {
            int buck = int.Parse(Console.ReadLine());
           
                double stack = price * buck;
                Console.WriteLine($"{buck } {name} цена {stack}");
                Console.WriteLine("Продолжить покупки?Ввод 1");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    int storage = buck;
                    number -= storage;
                }
            
        }
    }
}
