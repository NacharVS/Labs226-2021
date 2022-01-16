using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Health: Unit
    {


        private double _health;
        private double _currentHealth;

        public double MaxHealth
        {
            get
            {
                _health = 2 * Con + (0.5 * Str);
                return _currentHealth = _health;
            }
            set
            {
                _health = value;
            }
        }

        public double CurrentHealth
        {
            get 
            { 
                return _currentHealth; 
            }

            set
            {

                if ((MaxHealth - value) < CurrentHealth)
                {
                    Console.WriteLine($"Здоровье {Name} меньше 50%, поэтому все характеристики снижены на 10% ");

                    Str -= Str * 0.1;
                    Dex -= Dex * 0.1;
                    Intl -= Intl * 0.1;
                    Con -= Con * 0.1;



                }
            }
        }
    }
}
