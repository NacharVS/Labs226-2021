using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    interface IRangeWeapon
    {
        int Damage { get; set; }
        int Arrows { get; set; }

        void Hit();
    }
}