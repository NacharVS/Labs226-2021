﻿using System;

public class Class1
{
    public class Mage : Character
    {
        new public double Str
        {
            get => _str;
            set
            {
                _str = ToBound(value, 15, 45);
            }
        }

        new public double Dex
        {
            get => _dex;
            set
            {
                _dex = ToBound(value, 20, 80);
            }
        }

        new public double Con
        {
            get => _con;
            set
            {
                _con = ToBound(value, 15, 70);
            }
        }

        new public double Int
        {
            get => _int;
            set
            {
                _int = ToBound(value, 35, 250);
            }
        }

        new public void AttackM()
        {
            Console.WriteLine($"Юнит Mage  нанёс урон  по манекену {DamagM}");
        }

        new public void AttackP()
        {
            Console.WriteLine($"Юнит Mage  нанёс урон  по манекену {DamagP}");
        }
    }
}
