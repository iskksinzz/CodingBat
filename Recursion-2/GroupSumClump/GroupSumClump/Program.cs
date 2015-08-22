using System;

namespace GroupSumClump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupSumClump(0, new[] { 2, 4, 8 }, 10));
            Console.WriteLine(GroupSumClump(0, new[] { 1, 2, 4, 8, 1 }, 14));
            Console.WriteLine(GroupSumClump(0, new[] { 2, 4, 4, 8 }, 14));
            Console.ReadLine();
        }

        private static bool GroupSumClump(int start, int[] nums, int target)
        {
            int sum = 0;
            int val = start;

            if (start >= nums.Length)
                return target == 0;

            for (int i = start; i < nums.Length; i++)
            {
                if (nums[start] == nums[i])
                {
                    sum += nums[i];
                    val++;
                }
            }

            return GroupSumClump(val, nums, target - sum) || GroupSumClump(val, nums, target);
        }
    }
}
