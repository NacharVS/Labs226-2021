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

        public Warrior(IMleeWeapon warriosWeapon, IRangeWeapon warriorsRangeWeapon)
        {
            _warriosWeapon = warriosWeapon;
            _warriorsRangeWeapon = warriorsRangeWeapon;
        }

        public void ChangeWeapon(IMleeWeapon newWeapon)
        {
            _warriosWeapon = newWeapon;
        }
        public void ChangeRangeWeapon(IRangeWeapon newRangeWeapon)
        {
            _warriorsRangeWeapon = newRangeWeapon;
        }


        public void Attack()
        {
            if (_warriorsRangeWeapon.Arrow > 0)


            {
                _warriorsRangeWeapon.Hit();
            }
            else
            {
                Console.WriteLine("сменить оружие на ближнее");
                _warriosWeapon.Hit();
            }
        }

       
    }
}
