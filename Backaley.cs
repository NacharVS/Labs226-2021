using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Backaley
    {
        public static void BackaleySpisok()
        {
            double[] obshaichena = new double[10];
            double chena = 0;
            int stop = 0;
            int[] korzonaSchenoi = { 14, 20, 100, 40, 70, 20, 15, 25, 90, 150 };
            double[] korzina = new double[10];
            string[] spisok = { "№0 - гречка - 14", " №1 - хлеб - 20", " №2 - урюг - 100 ", " №3 яйца -40 ", " №4 сыр -70 ", " №5картофель - 20/кг ", " №6 морковь - 15/кг", " №7 лук - 25/кг", " №8 укроп - 90/кг", " №9 куряга - 150/кг" };
            for (int i = 0; i < spisok.Length; i++)
            {
                Console.Write(spisok[i]);
            }
            while (stop != 1)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите продук : ");
                Console.WriteLine("укажите его кол-во или граммы");

                korzina[int.Parse(Console.ReadLine())] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("если хотите прекратить покупки напишите х");
                stop = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Колл-во/Весс товаров");
            Console.WriteLine($"гречка - {korzina[0]} хлеб - {korzina[1]}, урюг - {korzina[2]}, яйца - {korzina[3]} , сыр - {korzina[4]} , картофель - {korzina[5]}кг , морковь - {korzina[6]}кг, лук - {korzina[7]}кг, укроп - {korzina[8]}кг, куряга - {korzina[9]}кг");

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
            Console.WriteLine("Цена каждого товара");
            Console.WriteLine($"гречка - {obshaichena[0]}руб. , хлеб - {obshaichena[1]}руб.  , урюг - {obshaichena[2]}руб.  , яйца - {obshaichena[3]}руб. , сыр - {obshaichena[4]}руб. , картофель - {obshaichena[5]}руб. , морковь - {obshaichena[6]}руб. , лук - {obshaichena[7]}руб. , укроп - {obshaichena[8]}руб. , куряга - {obshaichena[9]} руб.");


            for (int i = 0; i < obshaichena.Length; i++)
            {
                chena = obshaichena[i] + chena;
            }
            Console.WriteLine();
            Console.WriteLine(" Итого:");
            Console.Write($" {chena}");
        }
    }
}



























































































































































































