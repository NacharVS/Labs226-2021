using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class ShortBow : IRangeWeapon 
    {
        public int Damage { get => 5; set => throw new NotImplementedException(); }
        public int Arrow { get => ArrowCount; set => throw new NotImplementedException(); }

        public int ArrowCount = 5;

        public void Hit()
        {
            ArrowCount -= 1;
            Console.WriteLine($"Bow makes 'wshoooo' {Damage} DMG and have {ArrowCount} ARROWS");
        }
    }
}
