using System;

namespace GroupSum5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupSum5(0, new[] { 2, 5, 10, 4 }, 19));
            Console.WriteLine(GroupSum5(0, new[] { 2, 5, 10, 4 }, 17));
            Console.WriteLine(GroupSum5(0, new[] { 2, 5, 10, 4 }, 12));
            Console.ReadLine();
        }

        private static bool GroupSum5(int start, int[] nums, int target)
        {
            if (start >= nums.Length)
                return target == 0;

            if (nums[start] % 5 == 0)
            {
                if (start < nums.Length - 1 && nums[start + 1] != 1)
                    return GroupSum5(start + 1, nums, target - nums[start]);
                return GroupSum5(start + 2, nums, target - nums[start]);
            }
            return GroupSum5(start + 1, nums, target - nums[start]) || GroupSum5(start + 1, nums, target);
        }
    }
}
