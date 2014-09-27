using System;

namespace Has77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Has77(new[] { 1, 7, 7 }));
            Console.WriteLine(Has77(new[] { 1, 7, 1, 7 }));
            Console.WriteLine(Has77(new[] { 1, 7, 1, 1, 7 }));
            Console.ReadLine();
        }

        public static bool Has77(int[] nums)
        {
            for (var i = 0; i <= nums.Length - 2; i++)
            {
                if (nums[i] == 7 && nums[i + 1] == 7)
                    return true;
                if (i < nums.Length - 2 && (nums[i] == 7 && nums[i + 2] == 7))
                    return true;
            }
            return false;
        }
    }
}
