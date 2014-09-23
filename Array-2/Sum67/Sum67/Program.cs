using System;

namespace Sum67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum67(new[] { 1, 2, 2 }));
            Console.WriteLine(Sum67(new[] { 1, 2, 2, 6, 99, 99, 7 }));
            Console.WriteLine(Sum67(new[] { 1, 1, 6, 7, 2 }));
            Console.ReadLine();
        }

        public static int Sum67(int[] nums)
        {
            var six = false;
            var sum = 0;

            foreach (int num in nums)
            {
                if (num == 6) { six = true; }
                if (num == 7 && six) { six = false; continue; }
                if (!six) { sum += num; }
            }
            return sum;
        }
    }
}