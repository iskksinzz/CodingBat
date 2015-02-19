using System;

namespace CountClumps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountClumps(new[] { 1, 2, 2, 3, 4, 4 }));
            Console.WriteLine(CountClumps(new[] { 1, 1, 2, 1, 1 }));
            Console.WriteLine(CountClumps(new[] { 1, 1, 1, 1, 1 }));
            Console.ReadLine();
        }
        public static int CountClumps(int[] nums)
        {
            var b = false;
            var c = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    if (!b)
                    {
                        c++;
                        b = true;
                    }
                }
                else
                    b = false;
            }
            return c;
        }

    }
}


