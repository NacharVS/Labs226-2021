using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Task23(string[] args)
        {
            Console.WriteLine("Выберете действие + - * /");
            Console.WriteLine(" +  = 1 " +
                "- = 2 " +
                "* = 3" +
                "/ = 4");


            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите певое чилов");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторе чило");
            int d = int.Parse(Console.ReadLine());
            int r = 0;
            if (a == 1) { r = c + d; Console.WriteLine(r); }
            else if (a == 2) { r = c - d; Console.WriteLine(r); }
            else if (a == 3) { r = c * d; Console.WriteLine(r); }
            else if (a == 4) { r = c / d; Console.WriteLine(r); }
            else { Console.WriteLine("Выберети верное заначение действия"); }
        }

    }
}
