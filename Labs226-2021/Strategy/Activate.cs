using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Activate
    {
        public static void Activ()
        {
            int n = 50;
            int arr = 0;
            int magpoi = 100;
            Peasant peasant1 = new Peasant("peasant1", 1, 6, 3, 20, 3, "Bridge");
            Healer healer1 = new Healer("healer1", 1, 6, 3, n, 3, "hospital");
            Archer archer1 = new Archer("archer1", 10, 60, 3, 30, 3, "Bridge", arr);
            Magician magician1 = new Magician("magician1", 1, 6, 3, 100, 3, "Bridge", magpoi);

            Console.WriteLine("У вас есть 4 персонажа. Кого Персонажа вы хотите выбрать ?");
            Console.WriteLine("1. Peasant\n2. Healer\n3. Archer\n4. Magician");
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
                case 4:
                    Console.WriteLine("Вы выбрали Magician");
                    selectedCharacter = magician1;
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
                    if (rndCharacter == 4)
                    {
                        Console.WriteLine($"Был выбран рандомный персонаж - Magician");
                        selectedCharacter = magician1;
                    }
                    break;
            }

            if (selectedCharacter == peasant1)
            {
                Console.WriteLine("Ваш персонаж (Peasant) может добывать ресурсы в шахте");
                Console.WriteLine("Хотите ли, чтобы ваш персонаж пошел в шахту ?");
                string vibor = Console.ReadLine();
                if (vibor == "Да")
                {
                    Console.WriteLine();
                    Console.WriteLine("Peasant пошел добывать ресурсы в шахту");
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
                Console.WriteLine("Ваш персонаж (Healer) может лечить себя");
                Console.WriteLine("Хотите ли вы, чтобы ваш персонаж вылечил себя ?");
                string vibor = Console.ReadLine();
                if (vibor == "Да")
                {

                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        n += 10;
                        healer1.Produce();
                    }
                    healer1.CancelAction();


                    Console.WriteLine($"Healer вылечил себя до {n} hp");

                }
                else
                {
                    Console.WriteLine("Healer пошел отдыхать");
                }
            }

            if (selectedCharacter == archer1)
            {
                int vrag = 100;
                arr = new Random().Next(1, 4);


                Console.WriteLine("Ваш персонаж (Archer) может стрелять из лука в других персонажей");
                Console.WriteLine("Хотите ли вы, чтобы ваш персонаж начал стрелять из лука ?");
                string vibor = Console.ReadLine();

                if (vibor == "Да")
                {
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        archer1.Produce();
                        arr -= 1;
                        if (vrag > 0)
                        {
                            vrag -= 50;
                            if (arr <= 0)
                            {
                                archer1.CancelAction();
                                Console.WriteLine("Archer перешел на Ближний бой");
                                if (vrag > 0)
                                {
                                    archer1.Attack();
                                }
                                break;

                            }
                        }
                        if (vrag <= 0)
                        {
                            Console.WriteLine("Archer убил персонажа");
                            break;

                        }



                    }




                }
                else
                {
                    Console.WriteLine("Archer пошел отдыхать");
                }
            }


            if (selectedCharacter == magician1)
            {

                int fireball = 50;
                int frozeball = 10;
                int lightning = 100;

                Console.WriteLine("Ваш персонаж (Magician) может использовать заклинание против других персонажей");
                Console.WriteLine("Хотите ли вы, чтобы ваш персонаж начал использовать заклинание ?");
                string vibor = Console.ReadLine();
                int vrag = 100;

                if (vibor == "Да")
                {

                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        if (vrag > 0)
                        {
                            int vibormag = new Random().Next(1, 4);
                            if (vibormag == 1)
                            {
                                vrag -= fireball;
                                if (vrag < 0)
                                {
                                    Console.WriteLine($"У врага осталось 0 hp");
                                }
                                else
                                {
                                    Console.WriteLine($"У врага осталось {vrag} hp");
                                }
                                magpoi -= fireball;

                            }

                            if (vibormag == 2)
                            {
                                vrag -= frozeball;
                                if (vrag < 0)
                                {
                                    Console.WriteLine($"У врага осталось 0 hp");
                                }
                                else
                                {
                                    Console.WriteLine($"У врага осталось {vrag} hp");
                                }
                                magpoi -= frozeball;
                            }

                            if (vibormag == 3)
                            {
                                vrag -= lightning;
                                if (vrag < 0)
                                {
                                    Console.WriteLine($"У врага осталось 0 hp");
                                }
                                else
                                {
                                    Console.WriteLine($"У врага осталось {vrag} hp");
                                }
                                magpoi -= lightning;
                            }
                        }




                    }


                    Console.WriteLine("Magician убил врага");

                }
                else
                {
                    Console.WriteLine("Magician пошел готовить новые зелья");
                }
            }

        }
    }
}
