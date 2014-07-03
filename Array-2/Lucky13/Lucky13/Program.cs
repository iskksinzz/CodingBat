using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Lucky13(new[] { 0, 2, 4 }));
            Console.WriteLine(Lucky13(new[] { 1, 2, 3 }));
            Console.WriteLine(Lucky13(new[] { 1, 2, 4 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return true if the array contains no 1's and no 3's. */
        public static bool Lucky13(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i].Equals(1) || nums[i].Equals(3))
                    return false;
            }
            return true;
        }
    }
}
