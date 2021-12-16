using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
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
}
