using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class LightCrossbow : IRangeWeapon, IMleeWeapon
    {
        public int Damage { get => 10 ; set => throw new NotImplementedException(); }
        public int Arrow { get => CurrArrow ; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 0; set => throw new NotImplementedException(); }

        public int CurrArrow = 2;
        public void Hit()
        {
            Console.WriteLine($"LightCrossbow makes 'shot' with {Damage} and have {CurrArrow}");
        }
    }
}
