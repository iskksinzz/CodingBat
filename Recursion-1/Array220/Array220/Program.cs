using System;

namespace Array220
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array220(new[] { 1, 2, 20 }, 0));
            Console.WriteLine(Array220(new[] { 3, 30 }, 0));
            Console.WriteLine(Array220(new[] { 3 }, 0));
            Console.ReadLine();
        }

        private static bool Array220(int[] nums, int index)
        {
            if (nums.Length - 1 <= index || nums.Length < 2)
                return false;
            return nums[index] * 10 == nums[index + 1] || Array220(nums, index + 1);
        }
    }
}
