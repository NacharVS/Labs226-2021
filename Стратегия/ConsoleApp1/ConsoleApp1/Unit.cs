using System;

namespace Strategy
{
    public class Main0
    {
        public static void Main()
        {
            Console.WriteLine("Выберите юнита:");
            Console.WriteLine($"1 - Крестьянин");
            Console.WriteLine($"2 - Лучник");
            Console.WriteLine($"3 - Мечник");
            Console.WriteLine($"4 - Хиллер");
            int vibor = int.Parse(Console.ReadLine());
            if (vibor == 1)
            {
                Console.WriteLine("Вы выбрали Крестьянина");
                Console.WriteLine($"Ваши Характеристики: ");
                Console.WriteLine("Выберите действие: ");
                

            }
            else if (vibor == 2)
            {
                Console.WriteLine("Вы выбрали Лучника");
            }
            else if (vibor == 3)
            {
                Console.WriteLine("Вы выбрали Рыцаря");
            }
            else if (vibor == 4)
            {
                Console.WriteLine("Вы выбрали Хиллера");
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
        public int mindamage;
        public int maxdamage;
        public int speed;
        public int attackSpeed;
        public int minheal;
        public int maxheal;
        
        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{typeUnit} нанес {hit} урона");
        }
        public void Heal()
        {
            int heal = new Random().Next(minheal, maxheal);
            Console.WriteLine($"{typeUnit} полечил себя на {heal} ХП");
        }
        public void Produce()
        {
            Console.WriteLine($"{typeUnit} добывает ресурсы...");
        }
        public void ChangeMelee()
        {
            int ArrowCount = 20;
            if(ArrowCount == 0)
            {
                Console.WriteLine($"{typeUnit} меняет лук на кинжал и его урон понижается на 50%");
                mindamage /= 2;
                maxdamage /= 2;
            }
            else
            {
                Console.WriteLine("У вас еще есть стрелы, смена не возможна");
            }
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
            base.health = hp;
            base.attackSpeed = atspeed;
        }
        public Peasant peasant1 = new Peasant("Крестьянин",0,3,10,100,10);
        
    }
    public class Archer : Unit
    {
        public Archer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.health = hp;
            base.attackSpeed = aspeed;
        }
        public Archer peasant1 = new Archer("Лучник", 2, 6, 20, 120, 15);

    }
    public class Knight : Unit
    {
        public Knight(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.health = hp;
            base.attackSpeed = aspeed;
        }
        public Knight peasant1 = new Knight("Рыцарь", 5, 10, 8, 200, 8);

    }
    public class Healer : Unit
    {
        public Healer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, int minheal, int maxheal)
        {
            base.typeUnit = type;
            base.mindamage = mindamage;
            base.maxdamage = maxdamage;
            base.speed = speed;
            base.health = hp;
            base.attackSpeed = aspeed;
            base.minheal = minheal;
            base.maxheal = maxheal;
        }
        public Healer peasant1 = new Healer("Хиллер", 0, 2, 15, 150, 20, 10, 20);

    }


}
