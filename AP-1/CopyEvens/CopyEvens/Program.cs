using System;

namespace CopyEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyEvens(new[] { 3, 2, 4, 5, 8 }, 2);
            CopyEvens(new[] { 3, 2, 4, 5, 8 }, 3);
            CopyEvens(new[] { 6, 1, 2, 4, 5, 8 }, 3);
            Console.ReadLine();
        }

        private static int[] CopyEvens(int[] nums, int count)
        {
            var arr = new int[count];
            var j = 0;
            foreach (var num in nums)
            {
                if (count == j) { break; }
                if (num % 2 == 0)
                    arr[j++] = num;
            }
            return arr;
        }
    }
}
