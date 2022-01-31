using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class StoneAxe : IMleeWeapon, IRepairible
    {
        public int durability;
        public int Damage { get => 8; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 4; set => throw new NotImplementedException(); }
        int IRepairible.durability { get => durability; set => durability = value; }

        public void Hit()
        {
            Console.WriteLine($"StoneAxe makes 'chop-chop' with {Damage} and {AttackSpeed} ");
        }
    }
}