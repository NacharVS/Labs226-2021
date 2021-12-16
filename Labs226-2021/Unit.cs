using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Unit
    {
        private int _str;
        private int _dex;
        private int _con;
        private int _intl;

        private int _health;
        private int _mana;

        private int _physicalAttack;
        private int _physicalDefence;
        private int _magicAttack;
        private int _magicDefence;

       

        private int _currencyHealth;

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

        public int Health
        {
            get
            {
                return _health = 2 * _con + (5 / 10) * _str;
            }
            set
            {
                _health = value;

            }
        }

        public virtual int Mana
        {
            get { return _mana; }
            set
            {
                _mana = _intl * 3;
            }
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name - {_name}");
            Console.WriteLine($"Strength - {_str}\nAgil - {_dex}\nBuild - {_con}\nIntellect - {_intl}\nHealthpoint - {_currencyHealth}\nMana - {_mana}");
            Console.WriteLine();
            Console.WriteLine($"Physical attack - {_physicalAttack}\nPhysical defence - {_physicalDefence}");
        }

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


        public int CurrencyHealth
        {
            get => _currencyHealth; set
            {

                _currencyHealth = value;

                if (value <= Health)
                {
                    if (value > 0)
                    {
                        _currencyHealth = value;
                        if (value <= Health * 0.5 & value > 0)
                        {

                            Str -= Str * (1 / 10);
                            Dex -= Dex * (1 / 10);
                            Intl -= Intl * (1 / 10);
                            Con -= Con * (1 / 10);


                            Console.WriteLine($"Сила: {Str}");
                            Console.WriteLine($"Ловкость:  {Dex}");
                            Console.WriteLine($"Интеллект: {Intl}");
                            Console.WriteLine($"Телосложение: {Con}");
                        }
                    }
                    if (value <= 0)
                    {
                        _currencyHealth = 0;
                        Console.WriteLine($"{Name} мёртв.");

                    }
                }
                else
                    _currencyHealth = Health;

            }
        }













    }
}
