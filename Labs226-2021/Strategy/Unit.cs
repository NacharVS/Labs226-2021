using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Unit
    {
        private string _typeUnit;
        private int _minhealth;
        private int _maxhealth;
        private int _mindamage;
        private int _maxdamage;
        private int _minshoot;
        private int _maxshoot;
        private int _speed;
        private int _attackSpeed;
        private int _minheal;
        private int _maxheal;
        private int _hp;
        private int _arrows;
        private int _fireball;
        private int _staticstorm;
        private int _frostbite;
        private int _mp;
        private int _storage;
        private int _hpp;

        public string TypeUnit
        {
            get
            {
                return _typeUnit;
            }
            set
            {
                _typeUnit = value;
            }
        }
        
        public int Minhealth
        {
            get
            {
                return _minhealth;
            }
            set
            {
                _minhealth = value;
            }
        }

        public int Maxhealth
        {
            get
            {
                return _maxhealth;
            }
            set
            {
                _maxhealth = value;
            }
        }

        public int Mindamage
        {
            get
            {
                return _mindamage;
            }
            set
            {
                _mindamage = value;
            }
        }

        public int Maxdamage
        {
            get
            {
                return _maxdamage;
            }
            set
            {
                _maxdamage = value;
            }
        }

        public int Minshoot
        {
            get
            {
                return _minshoot;
            }
            set
            {
                _minshoot = value;
            }
        }

        public int Maxshoot
        {
            get
            {
                return _maxshoot;
            }
            set
            {
                _maxshoot = value;
            }
        } 
        
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public int AttackSpeed
        {
            get
            {
                return _attackSpeed;
            }
            set
            {
                _attackSpeed = value;
            }
        }
        public int Minheal
        {
            get
            {
                return _minheal;
            }
            set
            {
                _minheal = value;
            }
        }
        public int Maxheal
        {
            get
            {
                return _maxheal;
            }
            set
            {
                _maxheal = value;
            }
        }
        public int Hp
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
            }
        }
        public int Arrows
        {
            get
            {
                return _arrows;
            }
            set
            {
                _arrows = value;
            }
        }
        public int Fireball
        {
            get
            {
                return _fireball;
            }
            set
            {
                _fireball = value;
            }
        }
        public int Staticstorm
        {
            get
            {
                return _staticstorm;
            }
            set
            {
                _staticstorm = value;
            }
        }
        public int Frostbite
        {
            get
            {
                return _frostbite;
            }
            set
            {
                _frostbite = value;
            }
        }
        public int Mp
        {
            get
            {
                return _mp;
            }
            set
            {
                _mp = value;
            }
        }
        public int Storage
        {
            get
            {
                return _storage;
            }
            set
            {
                _storage = value;
            }
        }
        public int Hpp
        {
            get
            {
                return _hpp;
            }
            set
            {
                if (value > 0)
                    _hpp = value;
                else
                {
                    _hpp = 0;
                    Death();
                }
            }
        }
        public void currenthp()
        {
            _hpp = 0;
            _hp = new Random().Next(_minhealth, _maxhealth);
            Console.WriteLine($"{TypeUnit} current {_hpp += _hp} healpoint");
        }

        public void Attack()
        {
            int hit = new Random().Next(_mindamage, _maxdamage);
            Console.WriteLine($"{_typeUnit} delivered {hit} damage");
        }
        public void credits()
        {
            Console.WriteLine();
            Console.WriteLine("Creators: Босс качалки - Нотфуллин Альбрт, Креативный деректор - Никита Матвеев, Прораб - Лосев Кирилл");
        }
        public void title()
        {
            Console.WriteLine();
            Console.WriteLine("RPG TXT");
            Console.WriteLine();
        }
        public void Death()
        {
            Console.WriteLine($"{TypeUnit} died");
        }
    }
}
