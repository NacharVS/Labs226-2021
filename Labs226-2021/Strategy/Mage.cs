using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Mage : Unit
    {
        public Mage(string type, int speed, int minhp, int maxhp, int aspeed, int mp, int fireball, int frostbite, int staticstorm)
        {
            base.typeUnit = type;
            base.speed = speed;
            base.minhealth = minhp;
            base.maxhealth = maxhp;
            base.attackSpeed = aspeed;
            base.mp = mp;
            base.fireball = fireball;
            base.frostbite = frostbite;
            base.staticstorm = staticstorm;
        }
        public void Spell()
        {
            while ( mp > 5 )
                {
                int spell = new Random().Next(1, 4);
                if (mp >= fireball)
                {
                    if (spell == 1)
                    {
                        Console.WriteLine($"{typeUnit} cast fireball and dilivered {fireball} damage");
                        mp -= fireball;
                    }
                }
                if (mp >= frostbite)
                {
                    if (spell == 2)
                    {
                        Console.WriteLine($"{typeUnit} cast frostbite and dilivered {frostbite} damage");
                        mp -= frostbite;
                    }
                }
                if (mp >= staticstorm)
                {
                    if (spell == 3)
                    {
                        Console.WriteLine($"{typeUnit} cast staticstorm and dilivered {staticstorm} damage");
                        mp -= staticstorm;
                    }
                }
            }
            
            if (mp <= 5 )
            {
               
                Console.WriteLine("Mp is over");
            }
           
        }
    }
}
