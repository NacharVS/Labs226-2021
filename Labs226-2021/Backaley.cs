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
            string[] spisok = { "№0 - молоко - 140", " №1 - хлеб - 30", " №2 - мороженое - 59 ", " №3 яйца -40 ", " №4 сыр -70 ", " №5картофель - 20/кг ", " №6 морковь - 15/кг", " №7 лук - 25/кг", " №8 бананы - 47/кг", " №9 огурец - 24/кг" };
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
            Console.WriteLine($"молоко - {korzina[0]}");
            Console.WriteLine($"хлеб - {korzina[1]}");
            Console.WriteLine($"мороженое - {korzina[2]}");
            Console.WriteLine($"яйца - {korzina[3]} ");
            Console.WriteLine($"сыр - {korzina[4]}");
            Console.WriteLine( $"картофель - {korzina[5]}кг ");
            Console.WriteLine($"морковь - {korzina[6]}кг");
            Console.WriteLine($"лук - {korzina[7]}кг");
            Console.WriteLine($"бананы - {korzina[8]}кг");
            Console.WriteLine($"огурец - {korzina[9]}кг");
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