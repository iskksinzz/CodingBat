using System;

namespace CopyEndy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CopyEndy(new[] { 9, 11, 90, 22, 6 }, 2));
            Console.WriteLine(CopyEndy(new[] { 9, 11, 90, 22, 6 }, 3));
            Console.WriteLine(CopyEndy(new[] { 12, 1, 1, 13, 0, 20 }, 2));
            Console.ReadLine();
        }

        private static int[] CopyEndy(int[] nums, int count)
        {
            var arr = new int[count];
            var j = 0;
            foreach (var num in nums)
            {
                if (count == j) { break; }
                if (IsEndy(num))
                    arr[j++] = num;
            }
            return arr;
        }

        private static bool IsEndy(int n)
        {
            return (n >= 0 && n <= 10) || (n >= 90 && n <= 100);
        }
    }
}
