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

        private double _health;
        private double _mana;

        private double _physicalAttack;
        private double _physicalDefence;
        private double _magicAttack;
        private double _magicDefence;


        public virtual double Str { get => _str; set => _str = value; }
        public virtual double Dex { get => _dex; set => _dex = value; }
        public virtual double Con { get => _con; set => _con = value; }
        public virtual double Intl { get => _intl; set => _intl = value; }


        public double PhysicalAttack
        {
            get { return _physicalAttack; }

            set
            {
                _physicalAttack = _str * 3 + 0.5 * _dex;
            }

        }


        public double PhysicalDefence
        {
            get { return _physicalDefence; }

            set
            {
                _physicalDefence = _con * 0.5 + Dex * 3;
            }

        }



        public double MagicAttack
        {
            get { return _magicAttack; }

            set
            {
                _magicAttack = _intl * 4;
            }

        }


        public double MagicDefence
        {
            get { return _magicDefence; }

            set
            {
                _magicDefence = _intl * 2;
            }

        }




        public virtual double Health()
        {
            _health = 2 * Con + 0.5 * Str;

            if (_health < (0.5 * _health))
            {
                _str -= _str * 0.1;
                _dex -= _dex * 0.1;
                _intl -= _intl * 0.1;
                _con -= _con * 0.1;
            }
            return _health;


        }


        public double Mana
        {
            get { return _mana; }

            set
            {
                _mana = 2 * _intl;
            }


        }


        



        public virtual void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Сила - {Str}\nЛовкость - {Dex}\nВыносливость - {Con}\nИнтелект - {Intl}\nHP - {_health}");
        }






    }
}
