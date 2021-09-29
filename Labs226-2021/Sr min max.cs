using System;

namespace Заданиие_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B:"); 
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число C:");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c && b > c)
                Console.WriteLine("Число A больше всех, число B - среднее, число С меньше всех");
            else if (a > b && a > c && b < c)
                Console.WriteLine("Число A больше всех, число C - среднее, число B меньше всех");
            else if (b > c && a > c)
                Console.WriteLine("Число B больше всех, число А - среднее, число С меньше всех");
            else if (b > c && a < c)
                Console.WriteLine("Число B больше всех, число C - среднее, число A меньше всех");
            else if (c > b && a < b)
                Console.WriteLine("Число C больше всех, число B - среднее, число A меньше всех");
            else if (c > a && a > b)
                Console.WriteLine("Число C больше всех, число A - среднее, число C меньше всех");
        }
    }
}
