using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Mage : Unit
    {


        private int _currentHealth;




        public int Health
        {
            get
            {
                return _currentHealth = 2 * Con + (5 / 10 * Str);
            }
            set
            {
                int OldHealth = _currentHealth;
                _currentHealth = value;
                HealthEvent?.Invoke(OldHealth, value);
            }
        }





        public override int Str
        {
            get => base.Str;
            set
            {
                if (value >= 15 & value <= 45)
                {
                    base.Str = value;
                }
                else if (value < 15)
                {
                    base.Str = 15;
                }
                else if (value > 45)
                {
                    base.Str = 45;
                }
            }
        }

        public override int Dex
        {
            get => base.Dex;
            set
            {
                if (value >= 20 & value <= 70)
                {
                    base.Dex = value;
                }
                else if (value < 20)
                {
                    base.Dex = 20;
                }
                else if (value > 70)
                {
                    base.Dex = 70;
                }
            }
        }

        public override int Con
        {
            get => base.Con;
            set
            {
                if (value >= 15 & value <= 65)
                {
                    base.Con = value;
                }
                else if (value < 15)
                {
                    base.Con = 15;
                }
                else if (value > 65)
                {
                    base.Con = 65;
                }
            }
        }

        public override int Intl
        {
            get => base.Intl;
            set
            {
                if (value >= 30 & value <= 250)
                {
                    base.Intl = value;
                }
                else if (value < 30)
                {
                    base.Intl = 30;
                }
                else if (value > 250)
                {
                    base.Intl = 250;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя - {Name}");
            Console.WriteLine($"Сила - {Str}\nЛовкость - {Dex}\nТелосложение - {Con}\nИнтеллект - {Intl}\nHP - {Health}\nMana - {Mana}");
            Console.WriteLine();
            Console.WriteLine($"Физическая Атака - {PAttack}\nФизическая Защита - {PDefence}");
        }

        public delegate void HealthChange(int OldHealth, int NewHealth);
        public event HealthChange HealthEvent;

    }
}