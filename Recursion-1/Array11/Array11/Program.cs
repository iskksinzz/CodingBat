using System;

namespace Array11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array11(new[] { 1, 2, 11 }, 0));
            Console.WriteLine(Array11(new[] { 11, 11 }, 0));
            Console.WriteLine(Array11(new[] { 1, 2, 3, 4 }, 0));
            Console.ReadLine();
        }

        private static int Array11(int[] nums, int index)
        {
            if (nums.Length < index + 1) return 0;
            return nums[index] == 11 ? 1 + Array11(nums, index + 1) : Array11(nums, index + 1);
        }
    }
}
