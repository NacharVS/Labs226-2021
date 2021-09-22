using System;

namespace ConsoleApp2 { }
class Program
{
    static void Task31(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());


        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {

                    if (i + j + k == sum)
                    {
                        if (i != j)
                        {
                            if (j != k)
                            {


                                Console.WriteLine($"{ i}{ j}{ k}");
                            }
                        }

                    }

                }
            }


        }
    }
}
