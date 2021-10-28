using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Mage : Unit
    {
        public Mage(string type, int speed, int minhp, int maxhp, int aspeed, int mp, int fireball, int frostbite, int staticstorm)
        {
            base.TypeUnit = type;
            base.Speed = speed;
            base.Minhealth = minhp;
            base.Maxhealth = maxhp;
            base.AttackSpeed = aspeed;
            base.Mp = mp;
            base.Fireball = fireball;
            base.Frostbite = frostbite;
            base.Staticstorm = staticstorm;
        }
        public void Spell()
        {
            while ( Mp > 5 )
                {
                int spell = new Random().Next(1, 4);
                if (Mp >= Fireball)
                {
                    if (spell == 1)
                    {
                        Console.WriteLine($"{TypeUnit} cast fireball and dilivered {Fireball} damage");
                        Mp -= Fireball;
                    }
                }
                if (Mp >= Frostbite)
                {
                    if (spell == 2)
                    {
                        Console.WriteLine($"{TypeUnit} cast frostbite and dilivered {Frostbite} damage");
                        Mp -= Frostbite;
                    }
                }
                if (Mp >= Staticstorm)
                {
                    if (spell == 3)
                    {
                        Console.WriteLine($"{TypeUnit} cast staticstorm and dilivered {Staticstorm} damage");
                        Mp -= Staticstorm;
                    }
                }
            }
            
            if (Mp <= 5 )
            {
               
                Console.WriteLine("Mp is over");
            }
           
        }
    }
}
