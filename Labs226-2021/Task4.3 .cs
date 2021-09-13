using System;


class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int d = 0;
        int c = 0;
        int h = 0;
        while (a > 0)
        {
            c = a % 10;
            if (c != b)
            {
            d = d * 10 + a % 10;
            }
            a = a / 10;
        }
        while (d > 0)
        {
            h = h * 10 + d % 10;
            d = d / 10;
        }
        Console.WriteLine(c);
    }
}

