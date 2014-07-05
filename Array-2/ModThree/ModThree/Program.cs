using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ModThree(new[] { 2, 1, 3, 5 }));
            Console.WriteLine(ModThree(new[] { 2, 1, 2, 5 }));
            Console.WriteLine(ModThree(new[] { 2, 4, 2, 5 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return true if the array contains
         * either 3 even or 3 odd values all next to each other. */
        public static bool ModThree(int[] nums)
        {
            for (var i = 0; i <= nums.Length - 3; i++)
            {
                if (nums[i] % 2 == nums[i + 1] % 2 && nums[i + 2] % 2 == nums[i] % 2)
                    return true;
            }
            return false;
        }
    }
}
