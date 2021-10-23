using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    public class Main1
    {
        public static void Main()
        {
            Peasant peasant1 = new Peasant("Крестьянин", 0, 10, 10, 100, 250, 10);
            Archer archer1 = new Archer("Лучник", 0, 6, 15, 30, 15, 120, 300, 25);
            Healer healer1 = new Healer("Хиллер", 0, 15, 12, 200, 350, 1, 9, 7);

            Console.WriteLine();
            Console.WriteLine(peasant1);
            Console.WriteLine(archer1);
            Console.WriteLine(healer1);
        }
    }
    public class Unit
    {
        public string typeUnit;
        public int maxhealth;
        public int minhealth;
        public int mindamage;
        public int maxdamage;
        public int minArcherdamage;
        public int maxArcherdamage;
        public int speed;
        public int attackSpeed;
        public int minheal;
        public int maxheal;
        public int hp;
        public int arrows;

        public void Razdachahp()
        {

            hp = new Random().Next(minhealth, maxhealth);
            Console.WriteLine($"{typeUnit}  имеет {hp} очков здоровья");
        }
        public void Attack()
        {
            if (typeUnit != "Archer")
            {
                int hit = new Random().Next(mindamage, maxdamage);
                Console.WriteLine($"{typeUnit} нанёс {hit} урона");
            }
            else if (arrows != 0)
            {
                int archerDamage = new Random().Next(minArcherdamage, maxArcherdamage);
                Console.WriteLine($"{typeUnit} атакует стрелами и наносит {archerDamage} урона ");
                arrows = arrows - 1;
                Console.WriteLine();
            }
            else
            {
                int archerHit = new Random().Next(mindamage, maxdamage);
                Console.WriteLine($"{typeUnit} перешёл в ближний бой и начал наносить {archerHit} урона ");
                Console.WriteLine();
            }

        }
        public void Death()
        {
            int health = maxhealth;
            if (health == 0)
                Console.WriteLine($"{typeUnit} слегка умер");
        }
    }
}
