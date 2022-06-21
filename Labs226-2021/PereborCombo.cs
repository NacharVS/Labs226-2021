using System;

namespace Labs226_2021 { }
class Program
{
    static void PereborCombo(int sum)
    {
       


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
