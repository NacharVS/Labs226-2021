using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Div
{
   public class Charter 
    {
        public int _str;
        public int _dex;
        public int _int;
        public int _con;

        public int _mana;
        public double _healing;
        public double _damag;
        public double _def;
       
    }
   public class Warior : Charter
    {
        public int Str
        {
            get => _str;
            set
            {
                if (value > 250 & value < 30)
                {
                    _str = value;
                }
                else
                if(value < 30)
                {
                    _str = 30;

                }
                else
                {
                    _str = 250;
                }
            }
        }
        public int Dex
        {
            get => _dex;
            set
            {
                if (value > 80 & value < 20)
                {
                    _dex = value;
                }
                else
                if (value < 20)
                {
                    _dex = 20;

                }
                else
                {
                    _dex = 80;
                }
            }
        }
        public int Con
        {
            get => _con;
            set
            {
                if (value > 100 & value < 25)
                {
                    _con = value;
                }
                else
                if (value < 25)
                {
                    _con = 25;

                }
                else
                {
                    _con = 100;
                }
            }
        }
        public int Int
        {
            get => _int;
            set
            {
                if (value > 50  & value < 10)
                {
                    _int = value;
                }
                else
                if (value < 10)
                {
                    _int = 10;

                }
                else
                {
                    _int = 50;
                }
            }
        }
        public double Damag
        {
            get => _damag;
            set
            {
                value = Str * 0.2 + Dex * 0.2;
                _damag = value;
            }

        }
        public double Defense
        {
            get => _def;
            set
            {
                value = Dex * 0.1 + Con * 0.2;
                _def = value;
            }
        }

        public double Healing { get => _healing; set => _healing = 1.5 * Con + 0.5 * Str; }
        public int Mana { get => _mana; set => _mana = Int * 2; }
        
        public  void Attack()
        {

            Console.WriteLine($"Юнит Wrior  нанёс урон  по маникену {Damag}");
        }
        public void ShowInfo() 
        {
           Console.WriteLine($" Str - {Str} Dex - {Dex} Con - {Con} Int - {Int} Damage - {Damag} Health - {Healing} Mana - {Mana} Def - {Defense}");
       
        }


    }
}

