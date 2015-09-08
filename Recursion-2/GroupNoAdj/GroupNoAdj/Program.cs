using System;

namespace GroupSumClump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupNoAdj(0, new[] { 2, 5, 10, 4 }, 12));
            Console.WriteLine(GroupNoAdj(0, new[] { 2, 5, 10, 4 }, 14));
            Console.WriteLine(GroupNoAdj(0, new[] { 2, 5, 10, 4 }, 7));
            Console.ReadLine();
        }

        private static bool GroupNoAdj(int start, int[] nums, int target)
        {
            if (start >= nums.Length)
                return target == 0;
            return GroupNoAdj(start + 2, nums, target - nums[start]) || GroupNoAdj(start + 1, nums, target);
        }
    }
}