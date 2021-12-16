using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    
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
            get => _physicdamage = Str * 3 + Dex * 0.5; set => _physicdamage = value;
        }
        public double MagicDamage
        {
            get => _magicdamage = Str * 3 + Dex * 0.5; set => _magicdamage = value;
        }
        public double PhysicDefence
        {
            get => _physicdefence = Str * 3 + Dex * 0.5; set => _physicdefence = value;
        }
        public double MagicDefence
        {
            get => _magicdefence = Str * 3 + Dex * 0.5; set => _magicdefence = value;
        }

        public double Health { get => 2 * Con + 0.5 * Str; set => _health = value; }
        public int Mana { get => Int * 3; set => _mana= value; }

        public  void Attack()
        {
            Console.WriteLine($"Юнит  нанёс {PhysicDamage} уроа");
        }
        public void ShowInfo() 
        {
           Console.WriteLine($"Нынешние параметры Силы: {Str}, Ловкости: {Dex}, Телосложения: {Con}, Интелекта: {Int}, Физ. атаки: {PhysicDamage}, Маг. атаки: {MagicDamage}, Физ. защиты: {PhysicDefence}, Маг.защиты: {MagicDefence}, Здоровья: {Health}, Манны: {Mana}");
        }
    }
    
}
