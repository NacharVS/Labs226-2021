using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class ShortBow : IRangeWeapon
    {
        public int Damage { get => 5; set => throw new NotImplementedException(); }
        public int Arrows { get => HaveArrow; set => throw new NotImplementedException(); }

        public int HaveArrow = 1;

        public void Hit()
        {
            HaveArrow -= 1;
            Console.WriteLine($"Bow makes 'хтью' with {Damage} and have {HaveArrow} ");
        }
    }
}