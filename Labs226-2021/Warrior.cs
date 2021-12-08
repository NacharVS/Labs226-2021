using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    public class Charter
    {
        public int _str;
        public int _dex;
        public int _int;
        public int _con;
        public double _physicdamage;
        public double _magicdamage;
        public double _physicdefence;
        public double _magicdefence;
        public int _mana;
        public double _health;
        public void LvlUp()
        {
            int i = 5;
            while (i > 0)
            {
                Console.WriteLine($"У вас осталось {i} очков улудшения.Напишите название параметра, который вы хотите улудшить(Сила, Ловкость, Интелект, Телосложение");
                string n = Console.ReadLine();
                if (n == "Сила")
                {
                    Console.WriteLine("На сколько очков вы хотите улудшить этот параметр?");
                    int k = int.Parse(Console.ReadLine());
                    if (i >= k)
                    {
                        _str += k;
                        Console.WriteLine($"Параметр силы улудшен и составляет {_str}");
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение");
                    }
                }
                if (n == "Ловкость")
                {
                    Console.WriteLine("На сколько очков вы хотите улудшить этот параметр?");
                    int k = int.Parse(Console.ReadLine());
                    if (i >= k)
                    {
                        _dex += k;
                        Console.WriteLine($"Параметр Ловкость улудшен и составляет {_dex}");
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение");
                    }
                }
                if (n == "Интелект")
                {
                    Console.WriteLine("На сколько очков вы хотите улудшить этот параметр?");
                    int k = int.Parse(Console.ReadLine());
                    if (i >= k)
                    {
                        _int += k;
                        Console.WriteLine($"Параметр Интелект улудшен и составляет {_int}");
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение");
                    }
                }
                if (n == "Телосложение")
                {
                    Console.WriteLine("На сколько очков вы хотите улудшить этот параметр?");
                    int k = int.Parse(Console.ReadLine());
                    if (i >= k)
                    {
                        _con += k;
                        Console.WriteLine($"Параметр Телосложение улудшен и составляет {_con}");
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение");
                    }
                }
            }
        }
    }
    public class Mage : Charter
    {
        public int Str
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
        public int Dex
        {
            get => _dex;
            set
            {
                if (value > 70 & value < 20)
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
                    _dex = 70;
                }
            }
        }
        public int Con
        {
            get => _con;
            set
            {
                if (value > 65 & value < 15)
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
                    _con = 65;
                }
            }
        }
        public int Int
        {
            get => _int;
            set
            {
                if (value > 250 & value < 30)
                {
                    _int = value;
                }
                else
                if (value < 30)
                {
                    _int = 30;

                }
                else
                {
                    _int = 250;
                }
            }
        }
        public double PhysicDamage
        {
            get => _physicdamage;
            set
            {
                value = Str * 3 + Dex * 0.5;
                _physicdamage = value;
            }

        }
        public double MagicDamage
        {
            get => _magicdamage;
            set
            {
                value = Int * 4;
                _magicdamage = value;
            }

        }
        public double PhysicDefence
        {
            get => _physicdefence;
            set
            {
                value = Dex * 3 + Con * 0.5;
                _physicdefence = value;
            }
        }
        public double MagicDefence
        {
            get => _magicdefence;
            set
            {
                value = Int * 2;
                _magicdefence = value;
            }
        }

        public double Health { get => _health; set => _health = 2 * Con + 0.5 * Str; }
        public int Mana { get => _mana; set => _mana = Int * 3; }
        public void ShowInfo()
        {
            Console.WriteLine($"Нынешние параметры Силы: {Str}, Ловкости: {Dex}, Телосложения: {Con}, Интелекта: {Int}, Физ. атаки: {PhysicDamage}, Маг. атаки: {MagicDamage}, Физ. защиты: {PhysicDefence}, Маг.защиты: {MagicDefence}, Здоровья: {Health}, Манны: {Mana}");
        }
    }
    public class Warrior : Charter
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
                if (value > 80 & value < 15)
                {
                    _dex = value;
                }
                else
                if (value < 15)
                {
                    _dex = 15;

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
        public double PhysicDamage
        {
            get => _physicdamage;
            set
            {
                value = Str * 3 + Dex * 0.5;
                _physicdamage = value;
            }

        }
        public double MagicDamage
        {
            get => _magicdamage;
            set
            {
                value = Int * 4;
                _magicdamage = value;
            }

        }
        public double PhysicDefence
        {
            get => _physicdefence;
            set
            {
                value = Dex * 3 + Con * 0.5;
                _physicdefence = value;
            }
        }
        public double MagicDefence
        {
            get => _magicdefence;
            set
            {
                value = Int * 2;
                _magicdefence = value;
            }
        }

        public double Health { get => _health; set => _health = 2 * Con + 0.5 * Str; }
        public int Mana { get => _mana; set => _mana = Int * 3; }

        public  void Attack()
        {
            Console.WriteLine($"Юнит  нанёс {PhysicDamage} уроа");
        }
        public void ShowInfo() 
        {
           Console.WriteLine($"Нынешние параметры Силы: {Str}, Ловкости: {Dex}, Телосложения: {Con}, Интелекта: {Int}, Физ. атаки: {PhysicDamage}, Маг. атаки: {MagicDamage}, Физ. защиты: {PhysicDefence}, Маг.защиты: {MagicDefence}, Здоровья: {Health}, Манны: {Mana}");
        }
    }
    public class Archer : Charter
    {
        public int Str
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
        public int Dex
        {
            get => _dex;
            set
            {
                if (value > 70 & value < 20)
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
                    _dex = 70;
                }
            }
        }
        public int Con
        {
            get => _con;
            set
            {
                if (value > 65 & value < 15)
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
                    _con = 65;
                }
            }
        }
        public int Int
        {
            get => _int;
            set
            {
                if (value > 250 & value < 30)
                {
                    _int = value;
                }
                else
                if (value < 30)
                {
                    _int = 30;

                }
                else
                {
                    _int = 250;
                }
            }
        }
        public double PhysicDamage
        {
            get => _physicdamage;
            set
            {
                value = Str * 3 + Dex * 0.5;
                _physicdamage = value;
            }

        }
        public double MagicDamage
        {
            get => _magicdamage;
            set
            {
                value = Int * 4;
                _magicdamage = value;
            }

        }
        public double PhysicDefence
        {
            get => _physicdefence;
            set
            {
                value = Dex * 3 + Con * 0.5;
                _physicdefence = value;
            }
        }
        public double MagicDefence
        {
            get => _magicdefence;
            set
            {
                value = Int * 2;
                _magicdefence = value;
            }
        }

        public double Health { get => _health; set => _health = 2 * Con + 0.5 * Str; }
        public int Mana { get => _mana; set => _mana = Int * 3; }
        public void ShowInfo()
        {
            Console.WriteLine($"Нынешние параметры Силы: {Str}, Ловкости: {Dex}, Телосложения: {Con}, Интелекта: {Int}, Физ. атаки: {PhysicDamage}, Маг. атаки: {MagicDamage}, Физ. защиты: {PhysicDefence}, Маг.защиты: {MagicDefence}, Здоровья: {Health}, Манны: {Mana}");
        }
    }
}
