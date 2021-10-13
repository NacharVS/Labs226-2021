using System;


namespace Labs226_2021
{
    class Tasks
    {
        public static void SimpleMultiplicators()
        {
            int N = int.Parse(Console.ReadLine());
            if(N < 2 && N > int.MaxValue )
                Console.WriteLine("impossible to solve");
            else
            {

            }
        }

        public static void Dividers()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int countOfDividers = 0;
            if(a <= 0 && b <=0 && k <= 0)
                Console.WriteLine("impossible to solve");
            else
            {
                for (int i = a; i <= b; i++)
                {
                    countOfDividers = 0;
                    for (int j = 1; j <= b; j++)
                    {
                        if (i % j == 0)
                            countOfDividers += 1;
                    }
                    if(countOfDividers >= k)
                    Console.Write(i + " " );
                }
               
            }
        }


        public static void MaxSummOfDigits()
        {
            int N = int.Parse(Console.ReadLine());
            int maxSum = 0;
            int number = 0;
            for (int i = 1; i <= N; i++)
            {
                int buff = i;
                int summ = 0;
                while(buff > 0)
                {
                    summ += buff % 10;
                    buff = buff / 10;
                }
                if (maxSum < summ)
                {
                    maxSum = summ;
                    number = i;
                }


            }
            Console.Write(number);
            Console.WriteLine(" "+ maxSum);

        }

        public static void CountOfSeven()
        {
            int N = int.Parse(Console.ReadLine());
            int CountOfSeven = 0;
            for (int i = 1; i <= N; i++)
            {
                int buff = i;
                while(buff > 0)
                {
                    if(buff % 10 == 7)
                    {
                        CountOfSeven += 1;
                    }
                    buff = buff / 10;
                }
            }
            Console.WriteLine(CountOfSeven);
        }


    }
}
