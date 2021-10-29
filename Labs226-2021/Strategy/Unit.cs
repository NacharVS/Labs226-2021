using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    public class Unit
    {
        private string _name;
        private int _CurrentHealth;
        private int _MaxHealth;
        private int _MinDamage;
        private int _MaxDamage;
        private int _armor;
        private int _speed;

        private int _mana;
        private int _Healing;

        public int Healing { get => _Healing; set => _Healing = value; }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public int Health
        {
            get => _CurrentHealth;
            set
            {
                if (value > 0)
                {
                    _CurrentHealth = value;
                }
                else
                {
                    _CurrentHealth = 0;
                    Console.WriteLine();
                    Death();
                }
            }
        }
     

        internal void GetDamage(int damage)
        {
            Health = Health - damage ;
        }

        internal int InflictDamage()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }
        public int Mana { get => _mana; set => _mana = value; }
        public int MinDamage { get => _MinDamage; set => _MinDamage = value; }
        public int MaxDamage { get => _MaxDamage; set => _MaxDamage = value; }

        private void Death()
        {
            Console.WriteLine($"{_name} death");
        }
    }
    class Warrior : Unit
    {

    }
    class Archer : Unit
    {
        private int _CurrentArrows;
        private int _Range;

        public int CurrentArrows { get => _CurrentArrows; set => _CurrentArrows = value; }
        public int Range { get => _Range; set => _Range = value; }
       

    }
        class Mage : Unit
        {
        private int _Mana;

            public int Mana { get => _Mana; set => _Mana = 100; }
        public int Spell()
        {
            int Fireball = 20;
            int Frostbite = 15;
            int Staticstorm = 10;
            return Mana = 100;
            while (Mana > 5)
            {
                int spell = new Random().Next(1, 4);
                if (Mana >= Fireball)
                {
                    if (spell == 1)
                    {
                        Console.WriteLine($"{Name} cast fireball and dilivered {Fireball} damage");
                        Mana -= Fireball;
                        MinDamage = Fireball - 5;
                        MaxDamage = Fireball;
                    }
                }
                if (Mana >= Frostbite)
                {
                    if (spell == 2)
                    {
                        Console.WriteLine($"{Name} cast frostbite and dilivered {Frostbite} damage");
                        Mana -= Frostbite;
                        MaxDamage = Frostbite;
                        MinDamage = Frostbite - 5;
                    }
                }
                if (Mana >= Staticstorm)
                {
                    if (spell == 3)
                    {
                        Console.WriteLine($"{Name} cast staticstorm and dilivered {Staticstorm} damage");
                        Mana -= Staticstorm;
                        MaxDamage = Staticstorm;
                        MinDamage = Staticstorm - 5;
                    }
                }
                return MaxDamage;
                return MinDamage;
            }

            if (Mana <= 5)
            {

                Console.WriteLine("Mp is over");
            }

        }
    }
    class Healer : Unit
    {
            private int _Healing;

            public int Healing { get => _Healing; set => _Healing = value; }
    }

        
}


    

