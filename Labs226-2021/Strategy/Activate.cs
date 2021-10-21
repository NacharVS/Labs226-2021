using Labs226_2021.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Activate
    {
        public static void Activ()
        {
            Peasant peasant1 = new Peasant("peasant1", 1, 6, 3, 20, 3, "Bridge");
            Healer healer1 = new Healer("healer1", 1, 6, 3, 50, 3, "hospital");
            Archer archer1 = new Archer("archer1", 1, 6, 3, 30, 3, "Bridge", 5);

            Console.WriteLine("У вас есть 3 персонажа. Кого Персонажа вы хотите выбрать ?");
            Console.WriteLine("1. Peasant\n2. Healer\n3. Archer");
            Unit selectedCharacter = null;
            Console.WriteLine();
            int pers = int.Parse(Console.ReadLine());
            switch (pers)
            {
                case 1:
                    Console.WriteLine("Вы выбрали Peasant");
                    selectedCharacter = peasant1;
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали Healer");
                    selectedCharacter = healer1;
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали Archer");
                    selectedCharacter = archer1;
                    break;
                default:
                    int rndCharacter = new Random().Next(1, 4);
                    if (rndCharacter == 1)
                    {
                        Console.WriteLine($"Был выбран рандомный персонаж - Peasant");
                        selectedCharacter = peasant1;
                    }
                    if (rndCharacter == 2)
                    {
                        Console.WriteLine($"Был выбран рандомный персонаж - Healer");
                        selectedCharacter = healer1;
                    }
                    if (rndCharacter == 3)
                    {
                        Console.WriteLine($"Был выбран рандомный персонаж - Archer");
                        selectedCharacter = archer1;
                    }
                    break;
            }

            if (selectedCharacter == peasant1)
            {
                Console.WriteLine("Ваш персонаж (Peasant) может добывать ресурсы в шахте");
                Console.WriteLine("Хотите ли чтобы ваш персонаж пошел в шахту");
                string vibor = Console.ReadLine();
                if (vibor == "Да")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        peasant1.Produce();
                    }
                    peasant1.CancelAction();

                    int resources = new Random().Next(1, 5);
                    switch (resources)
                    {
                        case 1:
                            Console.WriteLine($"Peasant добыл {resources} стак угля");
                            break;
                        default:
                            Console.WriteLine($"Peasant добыл {resources} стака угля");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Peasant пошел отдыхать");
                }
            }

            if (selectedCharacter == healer1)
            {
                Console.WriteLine("Ваш персонаж (Healer) может лечить других персонажей");
                Console.WriteLine("Хотите ли вы, чтобы ваш персонаж вылечил другого юнита ?");
                string vibor = Console.ReadLine();
                if (vibor == "Да")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        healer1.Produce();
                    }
                    healer1.CancelAction();

                    Console.WriteLine("Healer вылечил персонажа");

                }
                else
                {
                    Console.WriteLine("Peasant пошел отдыхать");
                }
            }

            if (selectedCharacter == archer1)
            {
                Console.WriteLine("Ваш персонаж (Archer) может стрелять из лука в других персонажей");
                Console.WriteLine("Хотите ли вы, чтобы ваш персонаж начал стрелять в другого персонажа ?");
                string vibor = Console.ReadLine();
                if (vibor == "Да")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        archer1.Produce();
                    }
                    archer1.CancelAction();

                    Console.WriteLine("Archer убил персонажа");

                }
                else
                {
                    Console.WriteLine("Archer пошел отдыхать");
                }
            }




        }

    }
}
