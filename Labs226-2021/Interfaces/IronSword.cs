using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class IronSword : IMleeWeapon, IRepairible
    {

        private int _durability = 50;
        public int Damage { get => 9; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 8; set => throw new NotImplementedException(); }
        public int durability 
        { 
            get => _durability;
            set
            {
                if (_durability < 0)
                {
                    _durability = 0;
                }
                else
                    _durability = value;
            }
            
        }

        public void Hit()
        {
            Console.WriteLine($"Sword makes 'vjuh-vjuh' with {Damage} and {AttackSpeed} ");
        }
    }
}