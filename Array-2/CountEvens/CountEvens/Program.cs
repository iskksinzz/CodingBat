using System;

namespace CountEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountEvens(new[] { 2, 1, 2, 3, 4 }));
            Console.WriteLine(CountEvens(new[] { 2, 2, 0 }));
            Console.WriteLine(CountEvens(new[] { 1, 3, 5 }));
            Console.ReadLine();
        }

        /* Return the number of even ints in the given array. */
        public static int CountEvens(int[] nums)
        {
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 != 0) continue;
                count++;
            }
            return count;
        }
    }
}
