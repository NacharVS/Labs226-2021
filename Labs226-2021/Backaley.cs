using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Backaley
    {
        public static void BackaleySpisok()
        {
            double[] Obshayacena = new double[10];
            double cena = 0;
            int stop = 0;
            int[] korzinaScenoi = { 400000, 56, 50000000, 90, 700, 40, 67, 75, 67, 56 };
            double[] korzina = new double[10];
            string[] spisok = { "№0 - видеокарта rtx5090ti - 400000руб", " №1 - пакет - 56руб", " №2 - BMW M9 - 500000000руб ", " №3 чай - 90 ", " №4 наушники -700 ", " №5 малина - 40/кг ", " №6 морковь - 67/кг", " №7 свекла - 75/кг", " №8 кукуруза - 67/кг", " №9 томат - 56/кг" };
            for (int i = 0; i < spisok.Length; i++)
            {
                Console.WriteLine(spisok[i]);
            }
            while (stop != 1)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите продук : ");
                Console.WriteLine("Укажите его количествово или граммы продукта");

                korzina[int.Parse(Console.ReadLine())] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Если хотите прекратить покупки напишите F");
                stop = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Количество/Вес товаров");
            Console.WriteLine($"видеокарта rtx5090ti- {korzina[0]}, пакет - {korzina[1]}, BMW M9 - {korzina[2]}, чай - {korzina[3]} , наушники - {korzina[4]} , малина - {korzina[5]}кг , морковь - {korzina[6]}кг, свекла - {korzina[7]}кг, кукуруза - {korzina[8]}кг, томат - {korzina[9]}кг");

            Console.WriteLine();
            for (int i = 0; i < korzina.Length; i++)
            {
                if (i <= 4)
                {
                    Obshayacena[i] = Obshayacena[i] + korzinaScenoi[i] * korzina[i];

                }
                else
                {
                    Obshayacena[i] = Obshayacena[i] + korzinaScenoi[i] * (korzina[i]);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Цена каждого товара");
            Console.WriteLine($"видеокарта rtx5090ti - {Obshayacena[0]}руб. , пакет - {Obshayacena[1]}руб. , BMW M9 - {Obshayacena[2]}руб. , чай - {Obshayacena[3]}руб. , наушники - {Obshayacena[4]}руб. , малина - {Obshayacena[5]}руб. , морковь - {Obshayacena[6]}руб. , свекла - {Obshayacena[7]}руб. , кукуруза - {Obshayacena[8]}руб. , томат - {Obshayacena[9]} руб.");


            for (int i = 0; i < Obshayacena.Length; i++)
            {
                cena = Obshayacena[i] + cena;
            }
            Console.WriteLine();
            Console.WriteLine(" Итого:");
            Console.Write($" {cena}");
        }
    }
}




