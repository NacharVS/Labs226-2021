using System;

public class Rogue
{
 


public class Rogue : Character
    {
        new public double Str
        {
            get => _str;
            set
            {
                _str = ToBound(value, 20, 55);
            }
        }

        new public double Dex
        {
            get => _dex;
            set
            {
                _dex = ToBound(value, 30, 250);
            }
        }

        new public double Con
        {
            get => _con;
            set
            {
                _con = ToBound(value, 20, 80);
            }
        }

        new public double Int
        {
            get => _int;
            set
            {
                _int = ToBound(value, 15, 70);
            }
        }

        new public void AttackM()
        {

            Console.WriteLine($"Юнит Rogue  нанёс урон  по манекену {DamagM}");
        }
        new public void AttackP()
        {

            Console.WriteLine($"Юнит Rogue  нанёс урон  по манекену {DamagP}");
        }
    }
}
