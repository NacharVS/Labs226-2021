using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_pomoika
{

    class Program
    {
        public class Character
        {
            public delegate void HPeffects(double HPBaffValue);
            public event HPeffects HPreg;

            public double _str;
            public double _dex;
            public double _int;
            public double _con;
            public int _lvl;
            public double _mana;
            public double _health;
            public double _damag;
            public double _def;
            public double _critChanse;
            public double _critdamag;
            public double _maxHP;
            public double _maxMana;

            private bool HPDeBaff = false;
            private bool ManaDeBaff = false;


            public double Str
            {
                get => _str;
                set
                {
                    _str = 0;
                }
            }

            public double Dex
            {
                get => _dex;
                set
                {
                    _dex = 0;
                }
            }

            public double Con
            {
                get => _con;
                set
                {
                    _con = 0;
                }
            }

            public double Int
            {
                get => _int;
                set
                {
                    _int = 0;
                }
            }

            public double Health
            {
                get => _health;
                set
                {
                    _health = 2 * Con + 0.5 * Str;
                }
            }

            public void AttackM()
            {
                Console.WriteLine($"Юнит  нанёс урон  по манекену {DamagM}");
            }

            public void AttackP()
            {
                Console.WriteLine($"Юнит  нанёс урон  по манекену {DamagP}");
            }

            public int Lvl
            {
                get => _lvl;
                set
                {
                    value = 0;
                    _lvl = value;
                }

            }
            public double Mana
            {
                get => _mana;
                set
                {
                    _mana = Int * 2;
                }
            }

            public void Lvlup(int lvl)
            {
                if (_lvl != 50 && lvl + _lvl < 50)
                {
                    _lvl += lvl;
                    for (; lvl != 0; lvl--)
                    {
                        _str += _str * 0.1;
                        _dex += _dex * 0.1;
                        _int += _int * 0.1;
                        _con += _con * 0.1;
                        _mana += _mana * 0.1;
                        _health += _health * 0.1;
                        _damag += _damag * 0.1;
                        _def += _def * 0.1;
                        _critChanse += _critChanse * 0.1;
                        _critdamag += _critdamag * 0.1;
                    }
                }
                else
                {
                    Console.WriteLine("Лимит по лвл");
                }
            }

            public double ToBound(double value, double min, double max)
            {
                if (value < min) return min; 
                else if (value > max) return max;
                return value;
            }

            public void ManaEventListener(double mana)
            {
                _mana = ToBound(_mana + mana, 0, 3 * Int);
                if (_health < 0.2 * _maxMana && !ManaDeBaff)
                {
                    ManaDeBaff = true;
                    _maxHP *= 0.8;
                }
                else 
                {
                    ManaDeBaff = false;
                    _maxHP *= 0.8;
                }
            }

            public void HPEventListener(double hp)
            {
                _health = ToBound(_health + hp, 0, _maxHP);
                if (_health < _maxHP / 2 && !HPDeBaff)
                {
                    HPDeBaff = true;
                    _str *= 0.9;
                    _dex *= 0.9;
                    _int *= 0.9;
                    _con *= 0.9;
                    _mana *= 0.9;
                    _health *= 0.9;
                    _damag *= 0.9;
                    _def *= 0.9;
                    _critChanse *= 0.9;
                    _critdamag *= 0.9;
                    CalcMaxChar();
                }
                else 
                {
                    HPDeBaff = false;
                    _str /= 0.9;
                    _dex /= 0.9;
                    _int /= 0.9;
                    _con /= 0.9;
                    _mana /= 0.9;
                    _health /= 0.9;
                    _damag /= 0.9;
                    _def /= 0.9;
                    _critChanse /= 0.9;
                    _critdamag /= 0.9;
                    CalcMaxChar();
                }
            }

            public virtual void Regen(double regen)
            {
                Health += Health * 0.1;
                HPreg?.Invoke(regen);
                Console.WriteLine($"Здоровье отрегенировано. Здоровье в настоящий момент: {Health}");
            }
            
            public void ShowInfo()
            {
                Console.WriteLine($"Str - {Str} \nDex - {Dex} \nCon - {Con} \nInt - {Int} \nDamageM - {DamagM} \nDamageP - {DamagP} \nHealth - {Health} \nMana - {Mana} \nDefM - {DefenseM} \nDefP - {DefenseP} \nLvl - {Lvl} \nCritChanceM - {CritCgantM} \nCritChanceP - {CritCgantP} \nCritdamagM - {CritdamagM} \nCritdamagP - {CritdamagP}");
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

            public double CritdamagP
            {
                get => _critdamag;
                set
                {
                    _critdamag = DamagP * (2 + Dex * 0.05);
                }
            }

            public double CritdamagM
            {
                get => _critdamag;
                set
                {
                    _critdamag = DamagM * (2 + Int * 0.15);
                }
            }

            public double CritCgantM
            {
                get => _critChanse;
                set
                {
                    _critChanse = 20 + Int * 0.1;
                }
            }

            public double CritCgantP
            {
                get => _critChanse;
                set
                {
                    _critChanse = 20 + Dex * 0.3;
                }
            }

            public double MaxHP
            {
                get => _maxHP;
                set
                {
                    _maxHP = 2 * _con + 0.5 * _str;
                }
            }

            public double MaxMana
            {
                get => _maxMana;
                set
                {
                    _maxMana = 3 * _int;
                }
            }

            public void CalcMaxChar()
            {
                _maxHP = 2 * _con + 0.5 * _str;
                _maxMana = 3 * _int;
            }
        }

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
                    _int = ToBound(value, 35,250);
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


        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Mage kukoldun = new Mage();
            Rogue rogue = new Rogue();
            warrior.HPreg += warrior.HPEventListener;
            kukoldun.HPreg += kukoldun.HPEventListener;
            rogue.HPreg += rogue.HPEventListener;
            warrior.Con = 7100;
            warrior.Dex = 80804;
            warrior.Str = 5045;
            warrior.Int = 20;
            warrior.DamagP = 0;
            warrior.Mana = 0;
            warrior.Health = 0;
            warrior.DefenseP = 0;
            warrior.Lvl = 0;

            warrior.ShowInfo();
            warrior.AttackP();
            warrior.Lvlup(10);
            warrior.ShowInfo();
            warrior.Lvlup(48);
            warrior.ShowInfo();
            Console.WriteLine("\n\n");
            kukoldun.Con = 7100;
            kukoldun.Dex = 80804;
            kukoldun.Str = 5045;
            kukoldun.Int = 1;
            kukoldun.DamagM = 0;
            kukoldun.Mana = 0;
            kukoldun.Health = 0;
            kukoldun.DefenseM = 0;
            kukoldun.Lvl = 0;
            rogue.Con = 7100;
            rogue.Dex = 80804;
            rogue.Str = 5045;
            rogue.Int = 100;
            rogue.DamagP = 0;
            rogue.Mana = 35;
            rogue.Health = 0;
            rogue.DefenseP = 0;
            rogue.Lvl = 0;

            kukoldun.ShowInfo();
            kukoldun.AttackP();
            kukoldun.Lvlup(30);
            kukoldun.ShowInfo();
            kukoldun.Lvlup(78);
            kukoldun.ShowInfo();
            Console.WriteLine("--------------------------------");
            rogue.ShowInfo();

            rogue.Str = 1;
            rogue.Con = 1;
            rogue.Health = 1;
            // rogue.FallMan();
            // rogue.FallHel();
            Console.WriteLine();
            Console.WriteLine("___");
            Console.WriteLine();
            rogue.ShowInfo();
            Console.WriteLine("________________________________________________________________\n\n");
            rogue.Regen(0.5);
            rogue.AttackP();
            rogue.Lvlup(5);
            rogue.ShowInfo();
            rogue.Lvlup(15);
            rogue.ShowInfo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            rogue.Int = 10;
            // rogue.FallMan();
            rogue.ShowInfo();
            Console.ReadKey();
        }
    }
}
