using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Backaley
    {
        public static void BackaleySpisok()
        {
            double [] obshaichena = new double [10];
            double chena = 0;
            int stop = 0;
            int [] korzonaSchenoi = { 140, 30, 59, 40, 70, 20, 15, 25, 47, 24 };
            double[] korzina = new double[10];
            string[] spisok = { "№0 - молоко - 140", " №1 - хлеб - 30", " №2 - мороженое - 59 ", " №3 яйца -40 ", " №4 сыр -70 ", " №5картофель - 20/кг ", " №6 морковь - 15/кг", " №7 лук - 25/кг", " №8 бананы - 47/кг", " №9 огурец - 24/кг" };
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
                Console.WriteLine("если хотите прекратить покупки напишите 1");
                stop = int.Parse(Console.ReadLine());
        }
            Console.WriteLine("Коллво/Весс товаров");
            Console.WriteLine($"молоко - {korzina[0]} хлеб - {korzina[1]}, мороженое - {korzina[2]}, яйца - {korzina[3]} , сыр - {korzina[4]} , картофель - {korzina[5]}кг , морковь - {korzina[6]}кг, лук - {korzina[7]}кг, бананы - {korzina[8]}кг, огурец - {korzina[9]}кг");
           
            Console.WriteLine();
            for (int i = 0; i < korzina.Length; i++)
            {
                if (i <=4)
                {
                    obshaichena[i] = obshaichena[i] + korzonaSchenoi[i] * korzina[i];
                   
                }
                else
                {
                    obshaichena[i] = obshaichena[i] + korzonaSchenoi[i] * (korzina[i] );
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("Цена каждого товара");
            Console.WriteLine($"молоко - {obshaichena[0]}руб. , хлеб - {obshaichena[1]}руб.  , мороженое - {obshaichena[2]}руб.  , яйца - {obshaichena[3]}руб. , сыр - {obshaichena[4]}руб. , картофель - {obshaichena[5]}руб. , морковь - {obshaichena[6]}руб. , лук - {obshaichena[7]}руб. , бананы - {obshaichena[8]}руб. , огурец - {obshaichena[9]} руб." );
          
            
            for (int i = 0; i<obshaichena.Length; i++)
            {
                chena = obshaichena[i]+chena;
            }
            Console.WriteLine();
            Console.WriteLine(" Итого:") ;
            Console.Write($" {chena}");
        }
    }
}
