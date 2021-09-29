using System;

namespace Subudai
{
    class KOd_DLya_Podrugi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи значение суммы для которой мы будем подбирать комбинацию цифр:");
            int a = int.Parse(Console.ReadLine());
            for (int n = 0; n < 10; n++)
                for (int y = n + 1; y < 10; y++)
                    for (int x = y + 1; x < 10; x++)
                        if (n + y + x == a && n != y && n != x && x != y)
                            Console.WriteLine($"Вот одна из вариаций, а ну-ка попробуй её:{n}{y}{x}");
        }
    }
}
