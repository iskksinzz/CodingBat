using System;

namespace IsEverywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsEverywhere(new[] { 1, 2, 1, 3 }, 1));
            Console.WriteLine(IsEverywhere(new[] { 1, 2, 1, 3 }, 2));
            Console.WriteLine(IsEverywhere(new[] { 1, 2, 1, 3, 4 }, 1));
            Console.ReadLine();
        }

        public static bool IsEverywhere(int[] nums, int val)
        {
            for (var i = 0; i <= nums.Length - 2; i++)
            {
                if (nums[i] != val && nums[i + 1] != val)
                    return false;
            }
            return true;
        }
    }
}
