using System;

namespace GroupSum6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupSum6(0, new[] { 5, 6, 2 }, 8));
            Console.WriteLine(GroupSum6(0, new[] { 5, 6, 2 }, 9));
            Console.WriteLine(GroupSum6(0, new[] { 5, 6, 2 }, 7));

            Console.ReadLine();
        }

        private static bool GroupSum6(int start, int[] nums, int target)
        {
            if (start >= nums.Length)
                return target == 0;
            if (nums[start] == 6)
                return GroupSum6(start + 1, nums, target - nums[start]);
            return GroupSum6(start + 1, nums, target - nums[start]) || GroupSum6(start + 1, nums, target);
        }
    }
}
