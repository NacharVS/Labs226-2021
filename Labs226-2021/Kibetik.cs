using System;

namespace Magaz
{
    class Kibet
    {
        public static void Magazine(int a)
        {
            if (a == 1)
                Kibet.Avtorizaciya();
            else if (a < 1)
                Console.WriteLine("До встречи!");
        }
        public static void Avtorizaciya()
        { 
            Console.Write("Введите свою почту:");
            string Pochta = Console.ReadLine();
            Console.Write("Введите название своей улицы:");
            string AdressUlica = Console.ReadLine();
            Console.Write("");
            Console.Write("Введите номер своего дома:");
            string AdressDom = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Введите номер своей квартиры(если нет оставьте поле пустым):");
            string AdressKv = Console.ReadLine();
            int[] array1 = new int[6];
            Console.Write($"Ваш пользовательский Id:");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(10);
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Если хотите продолжить покупку введите 1, если хотите перейти к оплате введите 2, если хотите посмотреть корзину введите 3");
            int b = int.Parse(Console.ReadLine());
            if (b == 1)
                Console.WriteLine("Pokupki");
            else if (b == 2)
            {
                Console.WriteLine("Спасибо что заглянули в наш магазин) Для получения заказа пришлите свой Id пользователя в комментариях к оплате. Реквизиты для оплаты продуктов:");
                Console.WriteLine("Qiwi,Sberbank,Tinkoff:+79328482639(Рахимов Радион Батырович)");
                Console.WriteLine($"Vasha pochta: {Pochta}? Vash adress:ulica {AdressUlica}, dom {AdressDom}, kv {AdressKv}?");
            }
            else if (b == 3)
                Console.WriteLine("Korzina");
        }
    }
}
