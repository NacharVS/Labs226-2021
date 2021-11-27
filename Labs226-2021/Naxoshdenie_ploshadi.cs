using System;

namespace ConsoleApp4
{
    class Naxoshdenie_ploshadi_shara_po_R
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение площади шара по R");
            Console.WriteLine("Введите значение R");
            Console.WriteLine("R = ");
            int R = int.Parse(Console.ReadLine());
            double p = Math.PI;
            R = R * R;
            Console.WriteLine($"S шара = {4 * p * R}");
            int a = int.Parse(Console.ReadLine());
        }
    }
}