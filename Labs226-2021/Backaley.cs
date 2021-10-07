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
            for(int i =0; i<korzina.Length; i++)
            {
                Console.Write($" {korzina[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < korzina.Length; i++)
            {
                if (i <=4)
                {
                    obshaichena[i] = korzonaSchenoi[i] * korzina[i];
                   
                }
                else
                {
                    obshaichena[i] = korzonaSchenoi[i] * (korzina[i] );
                }
                
            }
            for (int i =0; i<obshaichena.Length; i++)
            {
                Console.Write($" {obshaichena[i]}");
            }
            for (int i = 0; i<obshaichena.Length; i++)
            {
                chena = obshaichena[i]+chena;
            }
        }
    }
}
