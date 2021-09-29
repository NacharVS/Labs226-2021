using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class Kod
    {
        public static void Lock()
        {
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                for (int d = 0; d < 10; d++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (i + d + k == sum)
                        {
                            if (i != d)
                            {
                                if (d != k)
                                {
                                    Console.WriteLine($"{ i}{ d}{ k}");
                                }
                            }

                        }

                    }
                }
            }
        }
    }
}
