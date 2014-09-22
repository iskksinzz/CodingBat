using System;

namespace BigDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigDiff(new[] { 10, 3, 5, 6 }));
            Console.WriteLine(BigDiff(new[] { 7, 2, 10, 9 }));
            Console.WriteLine(BigDiff(new[] { 2, 10, 7, 2 }));
            Console.ReadLine();
        }

        public static int BigDiff(int[] nums)
        {
            var h = nums[0];
            var l = nums[0];

            foreach (var n in nums)
            {
                if (n > h)
                    h = n;
                if (n < l)
                    l = n;
            }
            return h - l;
        }
    }
}
