using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class LightCrossbow : IRangeWeapon
    {
        public int Damage { get => 8; set => throw new NotImplementedException(); }
        public int Arrow { get => ArrowCount; set => throw new NotImplementedException(); }
        public int ArrowCount = 5;
        public void Hit()
        {
            while (ArrowCount > 0)
            {
                ArrowCount -= 1;
            }
            Console.WriteLine($"Bow makes 'wshoooo' with {Damage} DMG and have {ArrowCount} ARROWS");
        }
    }
}
