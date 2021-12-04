using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Unit
    {
        private double _str;
        private double _dex;
        private double _con;
        private double _intl;

        public double attack;
        public double health;


        public double Str { get => _str; set => _str = value; }
        public double Dex { get => _dex; set => _dex = value; }
        public double Con { get => _con; set => _con = value; }
        public double Intl { get => _intl; set => _intl = value; }


        public void Attack()
        {
            attack = Str * 0.2 + Dex * 0.2; 
        }


        public void Health()
        {
            health = 1.5 * Con + 0.5 * Str;
        }
        

        public void ShowInfo()
        {
            Console.WriteLine(Str);

            Console.WriteLine(attack);

            Console.WriteLine($"{health} HP"); 
        }

    }
}
