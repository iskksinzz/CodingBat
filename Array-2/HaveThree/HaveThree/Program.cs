using System;

namespace HaveThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasThree(new[] { 3, 1, 3, 1, 3 }));
            Console.WriteLine(HasThree(new[] { 3, 1, 3, 3 }));
            Console.WriteLine(HasThree(new[] { 3, 4, 3, 3, 4 }));
            Console.ReadLine();
        }

        public static bool HasThree(int[] nums)
        {
            var c = 0;
            for (var i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 3 && nums[i + 2] == 3)
                    c++;
            }
            return c == 2;
        }
    }
}
