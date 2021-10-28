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
        private int _getDamage;
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

        public int GetDamage
        {
            get
            {
                return _getDamage;
            }
            set
            {
                int hit = new Random().Next(mindamage, maxdamage);
                if (hit>)
                    _getDamage = value;
            }
        }

        public void Razdachahp()
        {

            hp = new Random().Next(minhealth, maxhealth);
            Console.WriteLine($"{typeUnit}  имеет {hp} очков здоровья");
        }
        public void Death()
        {
            int health = maxhealth;
            if (health == 0)
                Console.WriteLine($"{typeUnit} слегка умер");
        }
    }
    class Healer : Unit
    {
        public Healer(string type, int mindamage, int maxdamage, int speed, int maxhealth, int minhealth, int minheal, int maxheal, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.minhealth = minhealth;
            base.maxhealth = maxhealth;
            base.minheal = minheal;
            base.maxheal = maxheal;
            base.attackSpeed = aspeed;
        }
        public void Healing()
        {
            for (int i = maxhealth; i > hp; i += 0)
            {
                int heal = new Random().Next(minheal, maxheal);
                Console.WriteLine($"{typeUnit} вылечил {heal} очков здороьвя." + $"{typeUnit}" + $" {hp + heal} healthpoint");
                Console.Write($"{typeUnit} теперь имеет {hp + heal} очков здороьвя.");
                Console.WriteLine();
            }
        }
        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
        }
    }
    class Archer : Unit
    {
        public Archer(string type, int mindamage, int maxdamage, int minArcherdamage, int maxArcherdamage, int speed, int maxhealth, int minhealth, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.minArcherdamage = minArcherdamage;
            base.maxArcherdamage = maxArcherdamage;
            base.speed = speed;
            base.minhealth = minhealth;
            base.maxhealth = maxhealth;
            base.attackSpeed = aspeed;
        }
        public void Attack()
        {
            if (arrows != 0)
            {
                int archerDamage = new Random().Next(minArcherdamage, maxArcherdamage);
                Console.WriteLine($"{typeUnit} атакует стрелами и наносит {archerDamage} урона ");
                arrows -= 1;
                Console.WriteLine();
            }
            else
            {
                int archerHit = new Random().Next(mindamage, maxdamage);
                Console.WriteLine($"{typeUnit} перешёл в ближний бой и начал наносить {archerHit} урона ");
                Console.WriteLine();
            }
        }
    }
    class Peasant : Unit
        {
            public Peasant(string type, int mindamage, int maxdamage, int speed, int maxhealth, int minhealth, int aspeed)
            {
                base.typeUnit = type;
                base.mindamage = mindamage;
                base.maxdamage = maxdamage;
                base.speed = speed;
                base.minhealth = minhealth;
                base.maxhealth = maxhealth;
                base.attackSpeed = aspeed;
            }
            public void Attack()
            {
                int hit = new Random().Next(mindamage, maxdamage);
            }
            public void Produce()
            {
                Console.WriteLine($"{typeUnit} работает в шахте....");
            }
        }
        class Action
        {
            public void Fight(Unit peasant1, Unit healer1)
            {
                Console.WriteLine($"Юнит {peasant1.typeUnit} ударил палкой юнита {healer1.typeUnit}");

            }
        }
}
