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
}
