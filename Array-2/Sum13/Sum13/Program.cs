using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum13(new[] { 1, 2, 2, 1 }));
            Console.WriteLine(Sum13(new[] { 1, 1 }));
            Console.WriteLine(Sum13(new[] { 1, 2, 2, 1, 13 }));
            Console.ReadLine();
        }

        /* Return the sum of the numbers in the array, returning 0 for an empty array. 
         * Except the number 13 is very unlucky, so it does not count and numbers that come
         * immediately after a 13 also do not count. */
        public static int Sum13(int[] nums)
        {
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i].Equals(13))
                    i++;
                else
                    result += nums[i];
            }
            return result;
        }
    }
}
