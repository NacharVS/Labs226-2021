using System;

namespace Strategy
{
    public class Main0
    {
        public static void Main()
        {
            Peasant peasant1 = new Peasant("Крестьянин",0,3,10,100,10);
            Archer archer1 = new Archer("Лучник", 2, 6, 20, 120, 15);
            Knight knight1 = new Knight("Рыцарь", 5, 10, 8, 200, 8);
            Healer healer1 = new Healer("Хиллер", 0, 2, 15, 150, 20, 10, 20);
            Wizzard wizzard1 = new Wizzard("Маг", 0, 4, 10, 140, 20, 15, 20);

            Console.WriteLine("Выберите юнита:");
            Console.WriteLine($"1 - Крестьянин");
            Console.WriteLine($"2 - Лучник");
            Console.WriteLine($"3 - Мечник");
            Console.WriteLine($"4 - Хиллер");
            Console.WriteLine($"5 - Маг");
            int vibor = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (vibor == 1)
            {
                Console.WriteLine("Вы выбрали Крестьянина");
                peasant1.health = new Random().Next(peasant1.maxhealth / 2, peasant1.maxhealth);
                Console.WriteLine($"Ваше здоровье = {peasant1.health}");
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1 - Атаковать");
                Console.WriteLine("2 - Добывать ресурсы");
                Console.WriteLine();
                int vibor1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (vibor1 == 1)
                {
                    peasant1.Attack();
                }
                else if(vibor1 == 2)
                {
                    peasant1.Produce();
                }
            }

            else if (vibor == 2)
            {
                Console.WriteLine("Вы выбрали Лучника");
                archer1.health = new Random().Next(archer1.maxhealth / 2, archer1.maxhealth);
                Console.WriteLine($"Ваше здоровье = {archer1.health}");
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1 - Атаковать");
                Console.WriteLine("2 - Добывать ресурсы");
                Console.WriteLine("3 - Сменить лук на кинжал и атаковать(урон меньше на 50%)");
                Console.WriteLine();
                int vibor1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (vibor1 == 1)
                {
                    archer1.Attack();
                }
                else if (vibor1 == 2)
                {
                    archer1.Produce();
                }
                else if (vibor1 == 3)
                {
                    archer1.ChangeMelee();
                    archer1.Attack();
                }
            }

            else if (vibor == 3)
            {
                Console.WriteLine("Вы выбрали Рыцаря");
                knight1.health = new Random().Next(knight1.maxhealth / 2, knight1.maxhealth);
                Console.WriteLine($"Ваше здоровье = {knight1.health}");
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1 - Атаковать");
                Console.WriteLine("2 - Добывать ресурсы");
                Console.WriteLine();
                int vibor1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (vibor1 == 1)
                {
                    knight1.Attack();
                }
                else if (vibor1 == 2)
                {
                    knight1.Produce();
                }
            }

            else if (vibor == 4)
            {
                Console.WriteLine("Вы выбрали Хиллера");
                healer1.health = new Random().Next(healer1.maxhealth / 2, healer1.maxhealth);
                Console.WriteLine($"Ваше здоровье = {healer1.health}");
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1 - Атаковать");
                Console.WriteLine("2 - Добывать ресурсы");
                Console.WriteLine("3 - Лечить себя");
                Console.WriteLine();
                int vibor1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (vibor1 == 1)
                {
                    healer1.Attack();
                }
                else if (vibor1 == 2)
                {
                    healer1.Produce();
                }
                else if (vibor1 == 3)
                {
                    healer1.Heal();
                }
            }

            if (vibor == 5)
            {
                Console.WriteLine("Вы выбрали Мага");
                wizzard1.health = new Random().Next(wizzard1.maxhealth / 2, wizzard1.maxhealth);
                Console.WriteLine($"Ваше здоровье = {wizzard1.health}");
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1 - Атаковать");
                Console.WriteLine("2 - Добывать ресурсы");
                Console.WriteLine("3 - Огненный шар");
                Console.WriteLine();
                int vibor1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (vibor1 == 1)
                {
                    wizzard1.Attack();
                }
                else if (vibor1 == 2)
                {
                    wizzard1.Produce();
                }
                else if (vibor1 == 3)
                {
                    wizzard1.FireBall();
                }
            }

            else
            {
                Console.WriteLine("Введено некорректное число");
            }

        }
    }
    public class Unit
    {

        public string typeUnit;
        public int health;
        public int maxhealth;
        public int mindamage;
        public int maxdamage;
        public int speed;
        public int attackSpeed;
        public int minheal;
        public int maxheal;
        public int resours;
        public int minmagdamage;
        public int maxmagdamage;
        
        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{typeUnit} нанес {hit} урона");
        }
        public void Heal()
        {
            int heal = new Random().Next(minheal, maxheal);
            if (health < maxhealth)
            {
                health += heal;
                if (health > maxhealth)
                {
                    health = maxhealth;
                }
                Console.WriteLine($"{typeUnit} полечил себя на {heal} ХП");
                Console.WriteLine($"Ваше здоровье = {health}");
            }
            else if(health == maxhealth)
            {
                Console.WriteLine("Вы не можете себя лечить, ваше ХП полное");
            }
            
            
        }
        public void Produce()
        {
            Console.WriteLine($"{typeUnit} добывает ресурсы...");
            resours = new Random().Next(1, 5);
            Console.WriteLine($"Ваши ресурсы: {resours}");
        }
        public void ChangeMelee()
        {
            Console.WriteLine($"{typeUnit} меняет лук на кинжал и его урон понижается на 50%");
            mindamage /= 2;
            maxdamage /= 2;
        }
        public void FireBall()
        {
            int hit = new Random().Next(minmagdamage, maxmagdamage);
            float burn = 1;
            
            Console.WriteLine($"{typeUnit} использует Огненный шар и наносит {hit} урона");
            Console.WriteLine($"Противник горит и получает {burn} урона в секунду, в течении 5 сек.");
            Console.WriteLine($"Суммарный урон = {hit + burn * 5}");
        }

    }

    public class Peasant : Unit
    {
        public Peasant(string type, int mindamage, int maxdamage, int speed, int hp, int atspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.maxhealth = hp;
            base.attackSpeed = atspeed;
        }
        
        
    }
    public class Archer : Unit
    {
        public Archer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.maxhealth = hp;
            base.attackSpeed = aspeed;
        }
        

    }
    public class Knight : Unit
    {
        public Knight(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.maxhealth = hp;
            base.attackSpeed = aspeed;
        }
        

    }
    public class Healer : Unit
    {
        public Healer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, int minheal, int maxheal)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.maxhealth = hp;
            base.attackSpeed = aspeed;
            base.minheal = minheal;
            base.maxheal = maxheal;
        }
        

    }
    public class Wizzard : Unit
    {
        public Wizzard(string type, int mindamage, int maxdamage, int speed, int hp, int atspeed, int minmag, int maxmag)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.maxhealth = hp;
            base.attackSpeed = atspeed;
            base.minmagdamage = minmag;
            base.maxmagdamage = maxmag;
        }


    }


}
