using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Div
{
    public class Rogur : Charter


    {
        public double CritdamagP
        {
            get => _critdamag = DamagP * (2 + Dex * 0.05);
            set
            {
                _critdamag = DamagP * (2 + Dex * 0.05);
            }
        }
        public double CritdamagM
        {
            get => _critdamag = DamagM * (2 + Int * 0.15);
            set
            {
                _critdamag = DamagM * (2 + Int * 0.15);
            }
        }
        public double CritCgantM
        {
            get => _critChanse = 20 + Int * 0.1;
            set
            {
                _critChanse = 20 + Int * 0.1;
            }
        }
        public double CritCgantP
        {
            get => _critChanse = 20 + Dex * 0.3;
            set
            {
                _critChanse = 20 + Dex * 0.3;
            }
        }
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
            get => _damag = Int * 0.2 + Int / 10;
            set
            {
                value = Int * 0.2 + Int / 10;
                _damag = value;
            }

        }
        public double DefenseM
        {
            get => _def = Int * 0.3;
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
            get => _def = Dex * 0.1 + Con * 0.2;
            set
            {
                value = Dex * 0.1 + Con * 0.2;
                _def = value;
            }
        }
        public double Healing
        {
            get => _healing;
            set
            {
                if (Mana < 70)
                {
                    _healing -= (1.5 * Con + 0.5 * Str) * 0.2;
                }
                else
                {
                    _healing = 1.5 * Con + 0.5 * Str;
                }
                if (147.5 / 2 > Healing)
                {
                    _str -= _str * 0.1;
                    _dex -= _dex * 0.1;
                    _int -= _int * 0.1;
                    _con -= _con * 0.1;
                    _mana -= _mana * 0.1;
                    _healing -= _healing * 0.1;
                    _damag -= _damag * 0.1;
                    _def -= _def * 0.1;
                    _critChanse -= _critChanse * 0.1;
                    _critdamag -= _critdamag * 0.1;

                }
            }
        }
        public double Mana
        {
            get => _mana = Int * 2;
            set
            {


                _mana = Int * 2;
            }
        }
        public void FallHel()
        {
            if (147.5 / 2 > Healing)
            {
                _str -= _str * 0.1;
                _dex -= _dex * 0.1;
                _int -= _int * 0.1;
                _con -= _con * 0.1;
                _mana -= _mana * 0.1;
                _healing -= _healing * 0.1;
                _damag -= _damag * 0.1;
                _def -= _def * 0.1;
                _critChanse -= _critChanse * 0.1;
                _critdamag -= _critdamag * 0.1;

            }
        }
        public void FallMan()
        {
            if (Mana < 70)
            {
                Healing = Healing - (_healing * 0.2);
                Console.WriteLine();
            }
        }

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
            Console.WriteLine($" Str - {Str} Dex - {Dex} Con - {Con} Int - {Int} DamageM - {DamagM} DamageP - {DamagP} Health - {Healing} Mana - {Mana} DefM - {DefenseM} DefP - {DefenseP} Lvl - {Lvl} CritChanceM - {CritCgantM} CritChanceP - {CritCgantP} CritdamagM - {CritdamagM} CritdamagP - {CritdamagP}");

        }

    }
}
