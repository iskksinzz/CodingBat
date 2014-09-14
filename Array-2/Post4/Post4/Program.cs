using System;

namespace Post4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Post4(new[] { 2, 4, 1, 2 }));
            Console.WriteLine(Post4(new[] { 4, 1, 4, 2 }));
            Console.WriteLine(Post4(new[] { 4, 4, 1, 2, 3 }));
            Console.ReadLine();
        }

        /* Given a non-empty array of ints, return a new array containing the elements 
         * from the original array that come after the last 4 in the original array. */
        public static int[] Post4(int[] nums)
        {
            var i = nums.Length - 1;
            while (nums[i] != 4) { i--; }

            var arr = new int[nums.Length - i - 1];
            for (int j = 0; j < arr.Length; j++)
                arr[j] = nums[i + j + 1];

            return arr;
        }
    }
}