using System;

namespace SameEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SameEnd(new[] { 5, 6, 45, 99, 13, 5, 6 }, 1));
            Console.WriteLine(SameEnd(new[] { 5, 6, 45, 99, 13, 5, 6 }, 2));
            Console.WriteLine(SameEnd(new[] { 5, 6, 45, 99, 13, 5, 6 }, 3));
            Console.ReadLine();
        }

        /* Return true if the group of N numbers at the start and end of the array are the same.*/
        public static bool SameEnd(int[] nums, int len)
        {
            var b = true;
            for (int i = 0; i < len; i++)
            {
                b = nums[i] == nums[nums.Length - len + i];
            }
            return b;
        }
    }
}
