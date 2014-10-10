using System;

namespace TwoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoTwo(new[] { 4, 2, 2, 3 }));
            Console.WriteLine(TwoTwo(new[] { 2, 2, 4, 2 }));
            Console.WriteLine(TwoTwo(new[] { 4, 2, 2, 2 }));
            Console.ReadLine();
        }

        public static bool TwoTwo(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 2) continue;
                if (i >= 1 && nums[i - 1] == 2) continue;
                if (i < (nums.Length - 1) && nums[i + 1] == 2) continue;
                return false;
            }
            return true;
        }
    }
}
