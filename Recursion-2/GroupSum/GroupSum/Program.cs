using System;

namespace GroupSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupSum(0, new[] { 2, 4, 8 }, 10));
            Console.ReadLine();
        }

        private static bool GroupSum(int start, int[] nums, int target)
        {
            if (start >= nums.Length)
                return target == 0;
            if (GroupSum(start + 1, nums, target - nums[start]))
                return true;
            if (GroupSum(start + 1, nums, target))
                return true;
            return false;
        }
    }
}
