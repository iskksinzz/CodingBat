using System;

namespace Sum28
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Sum28(new[] { 2, 3, 2, 2, 4, 2 }));
            Console.WriteLine(Sum28(new[] { 2, 3, 2, 2, 4, 2, 2 }));
            Console.WriteLine(Sum28(new[] { 1, 2, 3, 4 }));
            Console.ReadLine();
        }

        public static bool Sum28(int[] nums)
        {
            var sum = 0;
            foreach (var num in nums)
            {
                if (num == 2)
                    sum += num;
            }
            return sum == 8;
        }
    }
}
