using System;

namespace Split53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Split53(new[] { 1, 1 }));
            Console.WriteLine(Split53(new[] { 1, 1, 1 }));
            Console.WriteLine(Split53(new[] { 2, 4, 2 }));
            Console.ReadLine();
        }

        private static bool Split53(int[] nums)
        {
            return SplitHelper(0, nums, 0, 0);
        }

        private static bool SplitHelper(int start, int[] nums, int grp1, int grp2)
        {
            if (start >= nums.Length)
                return grp1 == grp2;

            if (nums[start] % 5 == 0)
                return SplitHelper(start + 1, nums, grp1 + nums[start], grp2);

            if (nums[start] % 3 == 0 && nums[start] % 5 != 0)
                return SplitHelper(start + 1, nums, grp1, grp2 + nums[start]);

            return SplitHelper(start + 1, nums, grp1 + nums[start], grp2) || SplitHelper(start + 1, nums, grp1, grp2 + nums[start]);
        }
    }
}