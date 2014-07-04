using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(No14(new[] { 1, 2, 3 }));
            Console.WriteLine(No14(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(No14(new[] { 2, 3, 4 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return true if it contains no 1's or it contains no 4's. */
        public static bool No14(int[] nums)
        {
            var one = false;
            var four = false;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i].Equals(1)) { one = true; }
                if (nums[i].Equals(4)) { four = true; }
                if (one && four) return false;
            }
            return true;
        }
    }
}
