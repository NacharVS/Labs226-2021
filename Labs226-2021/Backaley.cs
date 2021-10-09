using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{ 
    class Backaley
    {
        public static void BackaleySpisok()
        {
            double[] obshaichena = new double[10];
            double chena = 0;
            int stop = 0;
            int[] korzonaSchenoi = { 140, 30, 59, 40, 70, 20, 15, 25, 47, 24 };
            double[] korzina = new double[10];
            string[] spisok = { " №0 - молоко - 140руб.", " №1 - хлеб - 30руб.", " №2 - мороженое - 59руб. ", " №3 - яйца - 40руб. ", " №4 - сыр - 70руб. ", " №5 - картофель - 20руб./кг ", " №6 - морковь - 15руб./кг", " №7 - лук - 25руб./кг", " №8 - бананы - 47руб./кг", " №9 - огурец - 24руб./кг" };
            for (int i = 0; i < spisok.Length; i++)
            {
                Console.WriteLine(spisok[i]);
            }
            while (stop != 1)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите продук : ");
                Console.WriteLine("укажите его кол-во или Кг");
                korzina[int.Parse(Console.ReadLine())] += double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("если хотите прекратить покупки напишите 1");
                stop = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Коллво/Весс товаров");
            if (korzina[0] != 0)
            {
                Console.WriteLine($"молоко - {korzina[0]} Шт");
            }
            if (korzina[1] != 0)
            {
                Console.WriteLine($"хлеб - {korzina[1]} Шт");
            }
            if (korzina[2] != 0)
            {
                Console.WriteLine($"мороженое - {korzina[2]} Шт");
            }
            if (korzina[3] != 0)
            {
                Console.WriteLine($"яйца - {korzina[3]} Шт");
            }
            if (korzina[4] != 0)
            {
                Console.WriteLine($"сыр - {korzina[4]} Шт");
            }
            if (korzina[5] != 0)
            {
                Console.WriteLine($"картофель - {korzina[5]}кг ");
            }
            if (korzina[6] != 0)
            {
                Console.WriteLine($"морковь - {korzina[6]}кг");
            }
            if (korzina[7] != 0)
            {
                Console.WriteLine($"лук - {korzina[7]}кг");
            }
            if (korzina[8] != 0)
            {
                Console.WriteLine($"бананы - {korzina[8]}кг");
            }
            if (korzina[9] != 0)
            {
                Console.WriteLine($"огурец - {korzina[9]}кг");
            }                                                
            Console.WriteLine();
            for (int i = 0; i < korzina.Length; i++)
            {
                if (i <= 4)
                {
                    obshaichena[i] = obshaichena[i] + korzonaSchenoi[i] * korzina[i];
                }
                else
                {
                    obshaichena[i] = obshaichena[i] + korzonaSchenoi[i] * (korzina[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Цена каждого товара в козине");
            if(obshaichena[0]!=0  )
            {
                Console.WriteLine($"молоко - {obshaichena[0]}руб.");
            }
            if (obshaichena[1] != 0)
            {
                Console.WriteLine($"хлеб - {obshaichena[1]}руб.");
            }
            if (obshaichena[2] != 0)
            {
                Console.WriteLine($"мороженое - {obshaichena[2]}руб.");
            }
            if (obshaichena[3] != 0)
            {
                Console.WriteLine($"яйца - {obshaichena[3]}руб.");
            }
            if (obshaichena[4] != 0)
            {
                Console.WriteLine($"сыр - {obshaichena[4]}руб.");
            }
            if (obshaichena[5] != 0)
            {
                Console.WriteLine($"картофель - {obshaichena[5]}руб.");
            }
            if (obshaichena[6] != 0)
            {
                Console.WriteLine($"морковь - {obshaichena[6]}руб.");
            }
            if (obshaichena[7] != 0)
            {
                Console.WriteLine($"лук - {obshaichena[7]}руб.");
            }
            if (obshaichena[8] != 0)
            {
                Console.WriteLine($"бананы - {obshaichena[8]}руб.");
            }
            if (obshaichena[9] != 0)
            {
                Console.WriteLine($"огурец - {obshaichena[9]} руб.");
            }          
            for (int i = 0; i < obshaichena.Length; i++)
            {
                chena = obshaichena[i] + chena;
            }
            Console.WriteLine();
            Console.WriteLine(" Итого:");
            Console.Write($" {chena}руб.");
        }
    }
}