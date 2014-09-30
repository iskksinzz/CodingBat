using System;

namespace TenRun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TenRun(new[] { 2, 10, 3, 4, 20, 5 }));
            Console.WriteLine(TenRun(new[] { 10, 1, 20, 2 }));
            Console.WriteLine(TenRun(new[] { 10, 1, 9, 20 }));
            Console.ReadLine();
        }

        public static int[] TenRun(int[] nums)
        {
            var x = nums[0];
            for (var i = 0; i < nums.Length; i++)
            {
                if (x % 10 != 0)
                    x = nums[i];
                if (nums[i] % 10 == 0)
                    x = nums[i];
                nums[i] = x;
            }
            return nums;
        }
    }
}
