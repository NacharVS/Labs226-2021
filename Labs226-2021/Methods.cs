namespace Labs226_2021
{
    class Methods
    {
        public static void Inc(ref int a)
        {
            a += 1;
            System.Console.WriteLine(a);
        }

        public static int Summ(int a, int b)
        {
            return a + b;
        }

        public static void Summ(int a, int b, out int res)
        {
            res = a + b;
        }

        public static void Summ(params int[] numbers)
        {
            int resuilt = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                resuilt += numbers[i];
            }
            System.Console.WriteLine(resuilt);
        }
    }
}
