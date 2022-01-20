using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Barak : Building
    {
        public Barak(string type, int health) : base("Barak", 75 , 50)
        {
        }
        public void training(string type)
        {
            Console.WriteLine($"Barak is training {type}");
        }
    }
}
