using System;

namespace Array6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array6(new[] { 1, 6, 4 }, 0));
            Console.WriteLine(Array6(new[] { 1, 4 }, 0));
            Console.WriteLine(Array6(new[] { 6 }, 0));
            Console.ReadLine();
        }

        private static bool Array6(int[] nums, int index)
        {
            if (nums.Length == 0)
                return false;
            if (nums[index] == 6)
                return true;
            return nums.Length > index + 1 && Array6(nums, index + 1);
        }
    }
}
