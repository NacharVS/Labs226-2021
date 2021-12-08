using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Div
{
    public class Charter
    {
        public double _str;
        public double _dex;
        public double _int;
        public double _con;
        public int _lvl;
        public double _mana;
        public double _healing;
        public double _damag;
        public double _def;
        public int Lvl
        {
            get => _lvl;
            set
            {
                value = 0;
                _lvl = value;
            }
        }
        public void Lvlup(int lvl)
        {
            if (_lvl != 50)
            {
                if (lvl + _lvl < 50)
                {

                    _lvl += lvl;
                    while (lvl != 0)
                    {
                        _str += _str * 0.1;
                        _dex += _dex * 0.1;
                        _int += _int * 0.1;
                        _con += _con * 0.1;
                        _mana += _mana * 0.1;
                        _healing += _healing * 0.1;
                        _damag += _damag * 0.1;
                        _def += _def * 0.1;
                        lvl -= 1;
                    }

                }
                else
                {
                    Console.WriteLine("Лимит по лвл");
                }

            }
            else
            {
                Console.WriteLine("Лимит по лвл");
            }

        } 
    }
    public class Warior : Charter
    {
        public double Str
        {
            get => _str;
            set
            {
                if (value > 250 & value < 30)
                {
                    _str = value;
                }
                else
                if (value < 30)
                {
                    _str = 30;

                }
                else
                {
                    _str = 250;
                }
            }
        }
        public double Dex
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
        public double Con
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
        public double Int
        {
            get => _int;
            set
            {
                if (value > 50 & value < 10)
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
        public double DamagM
        {
            get => _damag;
            set
            {
                value = Int * 0.2 + Int / 10;
                _damag = value;
            }

        }
        public double DefenseM
        {
            get => _def;
            set
            {
                value = Int * 0.3;
                _def = value;
            }
        }
        public double DamagP
        {
            get => _damag;
            set
            {
                value = Str * 0.2 + Dex * 0.2;
                _damag = value;
            }

        }
        public double DefenseP
        {
            get => _def;
            set
            {
                value = Dex * 0.1 + Con * 0.2;
                _def = value;
            }
        }

        public double Healing { get => _healing; set => _healing = 1.5 * Con + 0.5 * Str; }
        public double Mana { get => _mana; set => _mana = Int * 2; }
        public void AttackM()
        {

            Console.WriteLine($"Юнит Mage  нанёс урон  по маникену {DamagM}");
        }
        public void AttackP()
        {

            Console.WriteLine($"Юнит Mage  нанёс урон  по маникену {DamagP}");
        }
        public void ShowInfo()
        {
            Console.WriteLine($" Str - {Str} Dex - {Dex} Con - {Con} Int - {Int} DamageM - {DamagM} DamageP - {DamagP} Health - {Healing} Mana - {Mana} DefM - {DefenseM} DefP - {DefenseP} Lvl - {Lvl}");

        }
    }
            public class Mage : Charter
            {
                public double Str
                {
                    get => _str;
                    set
                    {
                        if (value > 45 & value < 15)
                        {
                            _str = value;
                        }
                        else
                        if (value < 15)
                        {
                            _str = 15;

                        }
                        else
                        {
                            _str = 45;
                        }
                    }
                }
                public double Dex
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
                public double Con
                {
                    get => _con;
                    set
                    {
                        if (value > 70 & value < 15)
                        {
                            _con = value;
                        }
                        else
                        if (value < 15)
                        {
                            _con = 15;

                        }
                        else
                        {
                            _con = 70;
                        }
                    }
                }
                public double Int
                {
                    get => _int;
                    set
                    {
                        if (value > 250 & value < 35)
                        {
                            _int = value;
                        }
                        else
                        if (value < 35)
                        {
                            _int = 35;

                        }
                        else
                        {
                            _int = 250;
                        }
                    }
                }
                public double DamagM
                {
                    get => _damag;
                    set
                    {
                        value = Int * 0.2 + Int / 10;
                        _damag = value;
                    }

                }
                public double DefenseM
                {
                    get => _def;
                    set
                    {
                        value = Int * 0.3;
                        _def = value;
                    }
                }
        public double DamagP
        {
            get => _damag;
            set
            {
                value = Str * 0.2 + Dex * 0.2;
                _damag = value;
            }

        }
        public double DefenseP
        {
            get => _def;
            set
            {
                value = Dex * 0.1 + Con * 0.2;
                _def = value;
            }
        }

        public double Healing { get => _healing; set => _healing = 1.5 * Con + 0.5 * Str; }
                public double Mana { get => _mana; set => _mana = Int * 2; }
                public void AttackM()
                {

                    Console.WriteLine($"Юнит Mage  нанёс урон  по маникену {DamagM}");
                }
        public void AttackP()
        {

            Console.WriteLine($"Юнит Mage  нанёс урон  по маникену {DamagP}");
        }
        public void ShowInfo()
                {
                    Console.WriteLine($" Str - {Str} Dex - {Dex} Con - {Con} Int - {Int} DamageM - {DamagM} DamageP - {DamagP} Health - {Healing} Mana - {Mana} DefM - {DefenseM} DefP - {DefenseP} Lvl - {Lvl}");

                }
            }
            public class Rogur : Charter


            {
                public double Str
                {
                    get => _str;
                    set
                    {
                        if (value > 55 & value < 20)
                        {
                            _str = value;
                        }
                        else
                        if (value < 20)
                        {
                            _str = 20;

                        }
                        else
                        {
                            _str = 55;
                        }
                    }
                }
                public double Dex
                {
                    get => _dex;
                    set
                    {
                        if (value > 250 & value < 30)
                        {
                            _dex = value;
                        }
                        else
                        if (value < 30)
                        {
                            _dex = 30;

                        }
                        else
                        {
                            _dex = 250;
                        }
                    }
                }
                public double Con
                {
                    get => _con;
                    set
                    {
                        if (value > 80 & value < 20)
                        {
                            _con = value;
                        }
                        else
                        if (value < 20)
                        {
                            _con = 20;

                        }
                        else
                        {
                            _con = 80;
                        }
                    }
                }
                public double Int
                {
                    get => _int;
                    set
                    {
                        if (value > 70 & value < 15)
                        {
                            _int = value;
                        }
                        else
                        if (value < 15)
                        {
                            _int = 15;

                        }
                        else
                        {
                            _int = 70;
                        }
                    }
                }
        public double DamagM
        {
            get => _damag;
            set
            {
                value = Int * 0.2 + Int / 10;
                _damag = value;
            }

        }
        public double DefenseM
        {
            get => _def;
            set
            {
                value = Int * 0.3;
                _def = value;
            }
        }
        public double DamagP
        {
            get => _damag;
            set
            {
                value = Str * 0.2 + Dex * 0.2;
                _damag = value;
            }

        }
        public double DefenseP
        {
            get => _def;
            set
            {
                value = Dex * 0.1 + Con * 0.2;
                _def = value;
            }
        }

        public double Healing { get => _healing; set => _healing = 1.5 * Con + 0.5 * Str; }
        public double Mana { get => _mana; set => _mana = Int * 2; }
        public void AttackM()
        {

            Console.WriteLine($"Юнит Mage  нанёс урон  по маникену {DamagM}");
        }
        public void AttackP()
        {

            Console.WriteLine($"Юнит Mage  нанёс урон  по маникену {DamagP}");
        }
        public void ShowInfo()
        {
            Console.WriteLine($" Str - {Str} Dex - {Dex} Con - {Con} Int - {Int} DamageM - {DamagM} DamageP - {DamagP} Health - {Healing} Mana - {Mana} DefM - {DefenseM} DefP - {DefenseP} Lvl - {Lvl}");

        }
    }
        }
    




