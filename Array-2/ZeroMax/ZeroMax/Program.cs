using System;

namespace ZeroMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ZeroMax(new[] { 0, 5, 0, 3 }));
            Console.WriteLine(ZeroMax(new[] { 0, 4, 0, 3 }));
            Console.WriteLine(ZeroMax(new[] { 0, 1, 0 }));
            Console.ReadLine();
        }

        public static int[] ZeroMax(int[] nums)
        {
            var t = 0;
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] % 2 == 1 && nums[i] > t)
                    t = nums[i];
                if (nums[i] != 0) continue;
                nums[i] = t;
            }
            return nums;
        }
    }
}
