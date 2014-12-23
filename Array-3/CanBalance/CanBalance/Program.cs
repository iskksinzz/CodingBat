using System;
using System.Linq;

namespace CanBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanBalance(new[] { 1, 1, 1, 2, 1 }));
            Console.WriteLine(CanBalance(new[] { 2, 1, 1, 2, 1 }));
            Console.WriteLine(CanBalance(new[] { 10, 10 }));
            Console.ReadLine();
        }

        private static bool CanBalance(int[] nums)
        {
            var val = nums.Sum();
            if (val % 2 == 0)
            {
                var j = 0;
                foreach (var i in nums)
                {
                    j += i;
                    if (j == val / 2) { return true; }
                }
            }
            return false;

        }
    }
}
