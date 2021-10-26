using System;

namespace task_1_MinMax
{
    class MaxMinMassive
    {
        public static void MM()
        {
            int[] nums = new int[10];
            int min = 100; int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(0, 100);
                Console.Write($" {nums[i]}");
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
            }
            Console.WriteLine($"max = {max} min = {min}");
        }

    }
}

