using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    interface IMleeWeapon
    {
        int Damage { get; set; }
        int AttackSpeed { get; set; }

        void Hit();
    }
}
