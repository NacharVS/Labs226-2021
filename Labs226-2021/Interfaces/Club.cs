using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class Club : IMleeWeapon, IRepairible
    {
        private static int _maxDurability = 50;
        private int _durability = _maxDurability;
        public int Damage { get => 6; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 4; set => throw new NotImplementedException(); }
        public int durability
        {
            get => _durability;
            set
            {
                if (_durability < 0)
                {
                    _durability = 0;
                }
                else if (value >= _maxDurability)
                {
                    _durability = _maxDurability;

                }
                else
                    _durability = value;
            }

        }

        public void Hit()
        {
            Console.WriteLine($"Club makes 'tuk-tuk' with {Damage} and {AttackSpeed} ");
        }
    }
}