using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class IronSword : IMleeWeapon, IRepairible
    {
        public int durability;
        public int Damage { get => 9; set => throw new NotImplementedException(); }
        public int AttackSpeed { get => 8; set => throw new NotImplementedException(); }
        int IRepairible.durability { get => durability; set => durability = value; }

        public void Hit()
        {
            Console.WriteLine($"Меч делает 'вжух-вжух' и наносит {Damage} урона со скоростью {AttackSpeed} ");
        }
    }
}