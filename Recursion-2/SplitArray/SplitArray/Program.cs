using System;

namespace SplitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitArray(new[] { 2,2 }));
            Console.WriteLine(SplitArray(new[] { 2, 3 }));
            Console.WriteLine(SplitArray(new[] { 5, 2, 3 }));
            Console.ReadLine();
        }

        private static bool SplitArray(int[] nums)
        {
            return SplitHelper(0, nums, 0);
        }

        private static bool SplitHelper(int start, int[] nums, int total)
        {
            if (start >= nums.Length)
                return total == 0;
            return SplitHelper(start + 1, nums, total + nums[start]) || SplitHelper(start + 1, nums, total - nums[start]);
        }
    }
}
