using System;
using Labs226_2021.Interfaces;
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

        public void ChangeMleeWeapon(IMleeWeapon newWeapon)
        {
            _warriosWeapon = newWeapon;

        }

        public void ChangeRangeWeapon(IRangeWeapon newWeapon)
        {
            _warriorsRangeWeapon = newWeapon;
        }

        public void Attack()
        {
            if (_warriorsRangeWeapon.Arrows > 0)
            {
                _warriorsRangeWeapon.Hit();
            }
            else
            {
                
                _warriosWeapon.Hit();
                _warriosWeapon.durability = _warriosWeapon.durability - 10;
                
            }
        }
    }
}