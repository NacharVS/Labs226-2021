using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Warrior : Unit
    {

        private int _health;
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
                if (value >= 30 & value <= 250)
                {
                    base.Str = value;
                }
                else if (value < 30)
                {
                    base.Str = 30;
                }
                else if (value > 250)
                {
                    base.Str = 250;
                }
            }
        }

        public override int Dex
        {
            get => base.Dex;
            set
            {
                if (value >= 15 & value <= 80)
                {
                    base.Dex = value;
                }
                else if (value < 15)
                {
                    base.Dex = 15;
                }
                else if (value > 80)
                {
                    base.Dex = 80;
                }
            }
        }

        public override int Con
        {
            get => base.Con;
            set
            {
                if (value >= 25 & value <= 100)
                {
                    base.Con = value;
                }
                else if (value < 25)
                {
                    base.Con = 25;
                }
                else if (value > 100)
                {
                    base.Con = 100;
                }
            }
        }

        public override int Intl
        {
            get => base.Intl;
            set
            {
                if (value >= 10 & value <= 50)
                {
                    base.Intl = value;
                }
                else if (value < 10)
                {
                    base.Intl = 10;
                }
                else if (value > 50)
                {
                    base.Intl = 50;
                }
            }
        }

        public virtual void ShowInfo()
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
