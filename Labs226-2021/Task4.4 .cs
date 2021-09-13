using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = int.Parse(Console.ReadLine());
            long b = int.Parse(Console.ReadLine());
            long bas = 0;
            long bes = 0;
            long h = 0;
            long hh = 0;
            long rr = 0;
            long gg = 0;

            while (a > 0 | b > 0)
            {
                bas = a % 10;
                bes = b % 10;
                a = a / 10;
                b = b / 10;
                if (bas != bes)
                {
                    h = bas + h * 10;
                    hh = bes + hh * 10;

                }
            }
            while (h > 0 | hh > 0)
            {
                bas = h % 10;
                bes = hh % 10;
                h = h / 10;
                hh = hh / 10;
                rr = bas + rr * 10;
                gg = bes + gg * 10;
            }
            Console.WriteLine(rr);
            Console.WriteLine(gg);

        }

    }
}
