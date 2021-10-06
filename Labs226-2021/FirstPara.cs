using System;

namespace ConsoleApp3
{
    class FirstPara
    {
        static void ZamenaPeremennih(string[] args)
        {
            Console.WriteLine("Замена переменных");

            Console.WriteLine("Введите значение a");
            Console.WriteLine("a =");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b");
            Console.WriteLine("b =");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a ={a}; b ={b}");

        }
        static void PloshadShara(string[] args)
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


