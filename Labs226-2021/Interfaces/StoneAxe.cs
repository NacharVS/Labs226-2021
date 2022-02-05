using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class StoneAxe : IMleeWeapon, IRepairible
    {

        private int _durability = 50;

        public int Damage { get => 8; set => throw new NotImplementedException(); }
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
                else
                    _durability = value;
            }
            
        }

        public void Hit()
        {
            Console.WriteLine($"StoneAxe makes 'chop-chop' with {Damage} and {AttackSpeed} ");
        }
    }
}