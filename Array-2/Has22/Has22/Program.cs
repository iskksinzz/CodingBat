using System;

namespace Has22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Has22(new[] { 1, 2, 2 }));
            Console.WriteLine(Has22(new[] { 1, 2, 1, 2 }));
            Console.WriteLine(Has22(new[] { 2, 1, 2 }));
            Console.ReadLine();
        }

        public static bool Has22(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
                if (nums[i] == 2 && nums[i + 1] == 2)
                    return true;
            return false;
        }
    }
}
