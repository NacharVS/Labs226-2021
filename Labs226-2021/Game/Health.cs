using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Health: Unit
    {
        private int _health;

        public int MaxHealth
        {
            get
            {
                return _health = 2 * Con + (5 / 10 * Str);
            }
            set
            {
                _health = value;
            }
        }
    }
}
