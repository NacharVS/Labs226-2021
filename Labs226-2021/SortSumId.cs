using System;


namespace Labs226_2021
{
    class SortSumId
    {
        public static void SumId()
        {
            int[] sum = new int[10];
            int[] id = new int[10];


            SortSumId.Matrix(ref sum, ref id);

            int max = sum[0];

            for (int i = 0; i < sum.Length; i++)
            {
                for (int j = 0; j < sum.Length - 1 - i; j++)
                {
                    if (sum[j] > sum[j + 1])
                    {
                        int bufsum = sum[j];
                        sum[j] = sum[j + 1];
                        sum[j + 1] = bufsum;

                        int bufid = id[j];
                        id[j] = id[j + 1];
                        id[j + 1] = bufid;
                    }
                }
            }

            Console.WriteLine();
            for (int k = 0; k < sum.Length; k++)
            {
                Console.WriteLine($"{id[k]}. {sum[k]} ");
            }
        }

        public static void Matrix(ref int[] sum, ref int[] id)
        {
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            int res = 0;
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                res = array[0, 0];
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    res += array[i, j + 1];
                }
                for (int g = 0; g < array.GetLength(0); g++)
                {
                    id[i] = i + 1;
                }
                sum[i] = res;
                Console.Write($"{id[i]}. {sum[i]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
