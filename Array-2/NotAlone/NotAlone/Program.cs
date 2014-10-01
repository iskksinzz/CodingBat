using System;

namespace NotAlone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NotAlone(new[] { 1, 2, 3 }, 2));
            Console.WriteLine(NotAlone(new[] { 1, 2, 3, 2, 5, 2 }, 2));
            Console.WriteLine(NotAlone(new[] { 3, 4 }, 3));
            Console.ReadLine();
        }

        public static int[] NotAlone(int[] nums, int val)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if ((i <= 0 || i >= nums.Length - 1) || nums[i] != val) continue;
                if (nums[i] == nums[i + 1] || nums[i] == nums[i - 1]) continue;

                nums[i] = nums[i - 1] > nums[i + 1] ? nums[i - 1] : nums[i + 1];
            }
            return nums;
        }
    }
}
