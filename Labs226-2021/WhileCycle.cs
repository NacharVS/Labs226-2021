using System;

namespace Labs226_2021
{
    class WhileCycle
    {
        public static void TaskOne()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int res1 = 0;
            int res2 = 0;

            while (firstNumber != 0 && secondNumber != 0)
            {
                if (firstNumber % 10 != secondNumber % 10)
                {
                    res1 = res1 * 10 + firstNumber % 10;
                    res2 = res2 * 10 + secondNumber % 10;
                    firstNumber = firstNumber / 10;
                    secondNumber = secondNumber / 10;
                }
                else
                {
                    firstNumber = firstNumber / 10;
                    secondNumber = secondNumber / 10;
                }
            }
            if (firstNumber == 0)
            {
                while (secondNumber > 0)
                {
                    res2 = res2 * 10 + secondNumber % 10;
                    secondNumber = secondNumber / 10;
                }
            }
            else
            {
                while (firstNumber > 0)
                {
                    res1 = res1 * 10 + firstNumber % 10;
                    firstNumber = firstNumber / 10;
                }
            }

            while (res1 > 0)
            {
                firstNumber = firstNumber * 10 + res1 % 10;
                res1 = res1 / 10;
            }
            while (res2 > 0)
            {
                secondNumber = secondNumber * 10 + res2 % 10;
                res2 = res2 / 10;
            }
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);


        }
    }
}
