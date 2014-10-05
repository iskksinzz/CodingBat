using System;

namespace CenteredAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CenteredAverage(new[] { 1, 2, 3, 4, 100 }));
            Console.ReadLine();
        }

        public static int CenteredAverage(int[] nums)
        {
            var max = nums[0];
            var min = nums[0];
            var c = 0;

            foreach (var i in nums)
            {
                if (i > max) max = i;
                if (i < min) min = i;
                c += i;
            }
            return (c - (max + min)) / (nums.Length - 2);
        }
    }
}
