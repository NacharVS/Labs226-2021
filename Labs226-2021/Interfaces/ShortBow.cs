using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class ShortBow : IRangeWeapon, IMleeWeapon
    {
        public int Damage { get => 7 ; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 3 ; set => throw new NotImplementedException(); }

        public void Hit()
        {
            Console.WriteLine($" ShortBow makes 'tu-tu-tu' with {Damage} and {AttackSpeed}");
        }
    }
}
