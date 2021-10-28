using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Unit
    {
        private string _typeUnit;
        private int _currentHealth;
        private readonly int _maxHealth;
        private int _mindamage;
        private int _maxdamage;
        private int _speed;
        private int _attackSpeed;
        private string _located;



        public int CurrentHealth
        {
            get => _currentHealth;
            set
            {
                if (value > _maxHealth)
                {
                    _currentHealth = _maxHealth;
                }
                else
                {
                    _currentHealth = value;
                }
            }
        }

        public string TypeUnit { get => _typeUnit; set => _typeUnit = value; }
        
        public int Maxdamage { get => _maxdamage; set => _maxdamage = value; }
        public int Mindamage { get => _mindamage; set => _mindamage = value; }
        public int Speed { get => _speed; set => _speed = value; }
        public int AttackSpeed { get => _attackSpeed; set => _attackSpeed = value; }
        public string Located { get => _located; set => _located = value; }

        public int Attack()
        {
            int hit = new Random().Next(_mindamage, _maxdamage);
            return hit;
        }

        
        


        public void Inflictdamage()
        {
            
        }

        //public void Moving()
        //{
        //    int walking = _speed;
        //    Console.WriteLine($"{_typeUnit} runs at a speed of {walking}");
        //}

        //public void HoldPositon()
        //{
        //    string position = _located;
        //    Console.WriteLine($"{_typeUnit} stands on {position} ");
        //}

        public void Death()
        {
            if (_currentHealth == 0)
            {
                Console.WriteLine($"{_typeUnit} died");
            }
        }

    }
}
