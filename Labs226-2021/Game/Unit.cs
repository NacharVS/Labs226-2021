using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Unit
    {
        private int _str;
        private int _dex;
        private int _con;
        private int _intl;

        private int _mana;

        private int _physicalAttack;
        private int _physicalDefence;
        private int _magicAttack;
        private int _magicDefence;

        private int _pCriticalChange;
        private int _mCriticalChange;
        private int _pCriticalDamage;
        private int _mCriticalDamage;



        private string _name;

        public string Name { get => _name; set => _name = value; }


        public virtual int Str
        {
            get => _str;
            set => _str = value;
        }
        public virtual int Dex { get => _dex; set => _dex = value; }
        public virtual int Con { get => _con; set => _con = value; }
        public virtual int Intl { get => _intl; set => _intl = value; }


        public int Mana
        {
            get { return _mana; }
            set
            {
                _mana = _intl * 3;
            }
        }


        //public virtual void ShowInfo()
        //{
        //    Console.WriteLine($"Имя - {_name}");
        //    Console.WriteLine($"Сила - {_str}\nЛовкость - {_dex}\nТелосложение - {_con}\nИнтеллект - {_intl}\nHP - {_currencyHealth}\nMana - {_mana}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Физическая Атака - {_physicalAttack}\nФизическая Защита - {_physicalDefence}");
        //}

        public int PAttack
        {
            get { return _physicalAttack; }
            set
            {
                _physicalAttack = _str * 3 + (5 / 10) * _dex;

            }
        }

        public int PDefence
        {
            get { return _physicalDefence; }
            set
            {
                _physicalDefence = _con * (5 / 10) + _dex * 3;
            }
        }

        public int MAttack
        {
            get { return _magicAttack; }
            set { _magicAttack = _intl * 4; }
        }


        public int MDefence
        {
            get { return _magicDefence; }
            set
            {
                _magicDefence = _intl * 2;
            }
        }


















    }
}