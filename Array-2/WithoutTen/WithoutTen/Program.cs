using System;

namespace WithoutTen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WithoutTen(new[] { 1, 10, 10, 2 }));
            Console.WriteLine(WithoutTen(new[] { 10, 2, 10 }));
            Console.WriteLine(WithoutTen(new[] { 1, 99, 10 }));
            Console.ReadLine();
        }

        /* Return a version of the given array where all the 10's have been removed. 
         * The remaining elements should shift left towards the start of the array as needed, 
         * and the empty spaces a the end of the array should be 0. */
        public static int[] WithoutTen(int[] nums)
        {
            var arr = new int[nums.Length];
            var j = 0;

            foreach (int num in nums)
            {
                if (num != 10)
                    arr[j++] = num;
            }
            return arr;
        }
    }
}