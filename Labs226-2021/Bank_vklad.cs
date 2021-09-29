using System;

namespace Задание_0
{
    class Vklad_v_bank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада, которую вы хотите внести в наш банк:");
            int a = int.Parse(Console.ReadLine());
            if (a <= 100)
                Console.WriteLine("Число процента годовых будет составлять 0");
            else if (a > 100 && a <= 1000)
                Console.WriteLine("Число процента годовых будет составлять 5");
            else if (a > 1000 && a <= 5000)
                Console.WriteLine("Число процента годовых будет составлять 7");
            else if (a > 5000 && a <= 50000)
                Console.WriteLine("Число процента годовых будет составлять 9");
            else (a > 50000)
                Console.WriteLine("Число процента годовых будет составлять 12");
        }
    }
}