using System;

namespace Either24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Either24(new[] { 1, 2, 2 }));
            Console.WriteLine(Either24(new[] { 4, 4, 1 }));
            Console.WriteLine(Either24(new[] { 4, 4, 1, 2, 2 }));
            Console.ReadLine();
        }

        public static bool Either24(int[] nums)
        {
            var two = false;
            var four = false;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 2 && nums[i + 1] == 2) two = true;
                if (nums[i] == 4 && nums[i + 1] == 4) four = true;
            }
            return (!two || !four) && (four || two);
        }
    }
}
