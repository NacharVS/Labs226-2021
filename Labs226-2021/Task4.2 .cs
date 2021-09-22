using System;

namespace ConsoleApp2 { }
class Program7
{
    static void Task42(string[] args)
    {
        long a = int.Parse(Console.ReadLine());
        long b = 0;
        while (a > 0)
        {
            b = b * 10 + a % 10;
            a = a / 10;
        }
        
            
        Console.WriteLine(b);



    }
}

