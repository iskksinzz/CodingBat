using System;

namespace ShiftLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShiftLeft(new[] { 6, 2, 5, 3 }));
            Console.WriteLine(ShiftLeft(new[] { 1, 2 }));
            Console.WriteLine(ShiftLeft(new[] { 1 }));
            Console.ReadLine();
        }

        /* Return an array that is "left shifted" by one */

        public static int[] ShiftLeft(int[] nums)
        {
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            return nums;
        }
    }
}
