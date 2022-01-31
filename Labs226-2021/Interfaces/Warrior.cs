using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class Warrior
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public IMleeWeapon _warriosWeapon;
        public IRangeWeapon _warriorsRangeWeapon;

        public Warrior(IMleeWeapon warriosWeapon)
        {
            _warriosWeapon = warriosWeapon;
        }

        public void ChangeWeapon(IMleeWeapon newWeapon)
        {
            _warriosWeapon = newWeapon;
        }

        public void Attack()
        {
            _warriosWeapon.Hit();
        }
    }
}
