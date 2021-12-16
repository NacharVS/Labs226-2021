using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Battle: Unit
    {
        public static void Battle1(Warrior war, Archer rog)
        {
            if (war.Health > 0)
            {
                if (war.PAttack >= new Random().Next(0, 20))
                {
                    Console.WriteLine($"{war.Name} наносит урон {rog.Name}");
                    rog.Health -= war.PAttack;
                   
                    Console.WriteLine($"Урон - {war.PAttack}");


                    Console.WriteLine($"{rog.Name} наносит урон {war.Name}");
                    war.Health -= rog.PAttack;
                    Console.WriteLine($"Урон - {rog.PAttack}");
                }
                else
                {
                    Console.WriteLine($"{war.Name} наносит урон {rog.Name}");
                    rog.Health -= war.PAttack;
                }
            }
        }


    }
}
