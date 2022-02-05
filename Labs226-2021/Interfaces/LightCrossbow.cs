using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class LightCrossbow : IRangeWeapon
    {
        public int Damage { get => 10; set => throw new NotImplementedException(); }
        public int Arrows { get => HaveArrow; set => throw new NotImplementedException(); }

        public int HaveArrow = 2;

        public void Hit() 
        {
            HaveArrow -= 1;
            Console.WriteLine($"LightCrossbow makes 'хтью' with {Damage} and have {HaveArrow} ");
        }
        
    }
}