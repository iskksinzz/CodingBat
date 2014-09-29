using System;

namespace TripleUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TripleUp(new[] { 1, 4, 5, 6, 2 }));
            Console.WriteLine(TripleUp(new[] { 1, 2, 3 }));
            Console.WriteLine(TripleUp(new[] { 1, 2, 4 }));
            Console.ReadLine();
        }

        public static bool TripleUp(int[] nums)
        {
            for (var i = 0; i <= nums.Length - 3; i++)
            {
                if ((nums[i] == nums[i + 1] - 1) && (nums[i + 1] + 1 == nums[i + 2]))
                    return true;
            }
            return false;
        }
    }
}
