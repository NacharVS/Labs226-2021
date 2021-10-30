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
                Health = Health - damage;
            }

            internal int InflictDamage()
            {
                return new Random().Next(MinDamage, MaxDamage);
            }

            public int MinDamage { get => _MinDamage; set => _MinDamage = value; }
            public int MaxDamage { get => _MaxDamage; set => _MaxDamage = value; }

            private void Death()
            {
                Console.WriteLine($"{_name} death");
            }
        }
        
        
        
        
    
}


    

