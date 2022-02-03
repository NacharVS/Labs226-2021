using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class Bow : IRangeWeapon
    {
        public int Damage { get => 8; set => throw new NotImplementedException(); }
        public int Arrow { get => GiveArrow; set => throw new NotImplementedException(); }
        public int GiveArrow = 1;
        public void Hit()
        {
            GiveArrow -= 1;
            Console.WriteLine($"Лук делает 'фиу' с домагом {Damage} и имеет {GiveArrow} стрел ");
        }
    }
}
