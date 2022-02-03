using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class ShortBow : IRangeWeapon, IMleeWeapon
    {
        public int Damage { get => 7 ; set => throw new NotImplementedException(); }
        public int Arrow { get => CurrArrow ; set => CurrArrow = value; }
        public int AttackSpeed { get => 0; set => throw new NotImplementedException(); }

        public int CurrArrow = 2;

        public void Hit()
        {
            Arrow -= 1;
            Console.WriteLine($" ShortBow makes 'tu-tu-tu' with {Damage} and have  {Arrow}");
        }
    }
}
