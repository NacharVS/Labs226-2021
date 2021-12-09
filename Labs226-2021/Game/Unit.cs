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

        private double _attack;
        private double _health;
        private double _mana;


        public virtual double Str { get => _str; set => _str = value; }
        public virtual double Dex { get => _dex; set => _dex = value; }
        public virtual double Con { get => _con; set => _con = value; }
        public virtual double Intl { get => _intl; set => _intl = value; }


        public double Attack 
        {
            get
            {
                return _attack;
            }

            set
            {
                _attack = Str * 0.2 + Dex * 0.2;
            }
        
        
        }


        public virtual double Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = 2 * Con + 0.5 * Str;

                if (_health < (0.5 * _health))
                {
                    _str -= _str * 0.1;
                    _dex -= _dex * 0.1;
                    _intl -= _intl * 0.1;
                    _con -= _con * 0.1;
                }
                
            }


        }


        public double Mana
        {
            get
            {
                return _mana;
            }

            set
            {
                _mana = 2 * Intl;
            }


        }


        



        public virtual void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Сила - {Str}\nЛовкость - {Dex}\nВыносливость - {Con}\nИнтелект - {Intl}\nHP - {Health}");
        }






    }
}
