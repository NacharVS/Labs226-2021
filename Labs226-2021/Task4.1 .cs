using System;

namespace ConsoleApp2 { }
class Program6
{
    static void Task41(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int d = a;
        if (b > 0)
        {
            d = d * a;
            b--;
        }
        Console.WriteLine(d);



    }
}

