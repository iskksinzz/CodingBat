using System;

namespace ZeroFront
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ZeroFront(new[] { 1, 0, 0, 1 }));
            Console.WriteLine(ZeroFront(new[] { 0, 1, 1, 0, 1 }));
            Console.WriteLine(ZeroFront(new[] { 1, 0 }));
            Console.ReadLine();
        }

        public static int[] ZeroFront(int[] nums)
        {
            var j = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) continue;
                nums[i] = nums[j];
                nums[j++] = 0;
            }
            return nums;
        }
    }
}