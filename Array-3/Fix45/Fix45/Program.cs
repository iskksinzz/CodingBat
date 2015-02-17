using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix45
{
    class Program
    {
        static void Main(string[] args)
        {
            Fix45(new[] { 5, 4, 9, 4, 9, 5 });
            Fix45(new[] { 1, 4, 1, 5 });
            Fix45(new[] { 1, 4, 1, 5, 5, 4, 1 });
            Console.ReadLine();
        }

        public static int[] Fix45(int[] nums)
        {
            int p = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 4)
                    continue;
                int temp = nums[i + 1];
                int ix = Array.IndexOf(nums, 5, p);
                nums[i + 1] = 5;
                nums[ix] = temp;
                p = Array.IndexOf(nums, 5, i + 2);
            }
            return nums;
        }
    }
}
