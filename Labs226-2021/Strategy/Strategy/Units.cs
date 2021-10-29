using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    public class Main1
    {
        public static void Main()
        {
            Peasant peasant1 = new Peasant("Шахтер", 5, 15, 10, 250, 170, 2);
            Archer archer1 = new Archer("Лучник", 0, 5, 10, 25, 20, 200, 120, 3, 2);
            Actions.Razdachahp(peasant1, archer1);
            Console.WriteLine(archer1.hp);
            Actions.Fight(peasant1, archer1);
            Actions.Fight(peasant1, archer1);
            Actions.Fight(peasant1, archer1);
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
        public int hit;
        public int arrows;

        public int GetDamage
        {
            get
            {
                return _getDamage;
            }
            set
            {
                    _getDamage = value;
            }
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
        public Archer(string type, int mindamage, int maxdamage, int minArcherdamage, int maxArcherdamage, int speed, int maxhealth, int minhealth, int aspeed, int arrows)
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
            base.arrows = arrows;
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
            public void Produce()
            {
                Console.WriteLine($"{typeUnit} работает в шахте....");
            }
        }
    class Actions
    {
        public static void Fight(Peasant peasant1, Archer archer1)
        {
            int hit1 = new Random().Next(peasant1.mindamage, peasant1.maxdamage);
            int Ahit2 = new Random().Next(archer1.mindamage, archer1.maxdamage);
            int hit2 = new Random().Next(archer1.minArcherdamage, archer1.maxArcherdamage);
            Console.WriteLine($"{peasant1.typeUnit} достал кирку и нанес {hit1} урона по {archer1.typeUnit}");
            archer1.hp -= hit1;
            Console.WriteLine($"У {archer1.typeUnit} осталось {archer1.hp}");
            if (archer1.arrows != 0)
            {
                Console.WriteLine($"{archer1.typeUnit} вынул стрелу из-за спины и, нанеся {Ahit2} урона, стрелой попал в {peasant1.typeUnit}");
                archer1.arrows -= 1;
                archer1.hp -= Ahit2;
            }
            else
            {
                Console.WriteLine($"{archer1.typeUnit} достал клинок и перешёл в ближний бой с {peasant1.typeUnit}, тем самым нанес Ему {hit2} урона");
                archer1.hp -= hit2;
            }
            Console.WriteLine($"У {peasant1.typeUnit} осталось {peasant1.hp}");
        }
        public static void Razdachahp(Peasant p1, Archer ar1)
        {
            ar1.hp = new Random().Next(ar1.minhealth, ar1.maxhealth);
            Console.WriteLine($"{ar1.typeUnit}  имеет {ar1.hp} очков здоровья");
            p1.hp = new Random().Next(p1.minhealth, p1.maxhealth);
            Console.WriteLine($"{p1.typeUnit}  имеет {p1.hp} очков здоровья");
        }
    }
}
