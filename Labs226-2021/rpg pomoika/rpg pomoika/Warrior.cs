using System;

public class Class1
{
    public class Warrior : Character
    {
        new public double Str
        {
            get => _str;
            set
            {
                _str = ToBound(value, 30, 250);
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
                _con = ToBound(value, 25, 100);
            }
        }

        new public double Int
        {
            get => _int;
            set
            {
                _int = ToBound(value, 10, 50);
            }
        }

        new public void AttackM()
        {
            Console.WriteLine($"Юнит Warrior  нанёс урон  по манекену {DamagM}");
        }

        new public void AttackP()
        {
            Console.WriteLine($"Юнит Warrior  нанёс урон  по манекену {DamagP}");
        }
    }
