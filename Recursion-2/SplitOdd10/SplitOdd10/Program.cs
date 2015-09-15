using System;

namespace SplitOdd10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitOdd10(new[] { 5, 5, 5 }));
            Console.WriteLine(SplitOdd10(new[] { 5, 5, 6 }));
            Console.WriteLine(SplitOdd10(new[] { 5, 5, 6, 1 }));
            Console.ReadLine();
        }

        private static bool SplitOdd10(int[] nums)
        {
            return SplitHelper(0, nums, 0, 0);
        }

        private static bool SplitHelper(int start, int[] nums, int grp1, int grp2)
        {
            if (start >= nums.Length)
                return (grp1 % 10 == 0 && grp2 % 2 == 1) || 
                        (grp2 % 10 == 0 && grp1 % 2 == 1);

            return SplitHelper(start + 1, nums, grp1 + nums[start], grp2) || SplitHelper(start + 1, nums, grp1, grp2 + nums[start]);
        }
    }
}