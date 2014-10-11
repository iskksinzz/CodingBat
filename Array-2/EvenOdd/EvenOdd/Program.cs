using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOdd(new[] { 1, 0, 1, 0, 0, 1, 1 }));
            Console.WriteLine(EvenOdd(new[] { 3, 3, 2 }));
            Console.WriteLine(EvenOdd(new[] { 2, 2, 2 }));
            Console.ReadLine();
        }

        public static int[] EvenOdd(int[] nums)
        {
            var arr = new int[nums.Length];
            var even = 0;
            var odd = arr.Length - 1;

            foreach (var i in nums)
                if (i % 2 == 0)
                    arr[even++] = i;
                else
                    arr[odd--] = i;
            return arr;
        }
    }
}
