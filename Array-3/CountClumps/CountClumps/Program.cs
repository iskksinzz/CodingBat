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
            int c = 0, k = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    if (i > 0 && nums[i] == nums[i - 1])
                        continue;
                    c++;
                }
                else
                {
                    if (c > 0)
                        k++;
                    c = 0;
                }
            }
            if (c > 0) k++;
            return k;
        }

    }
}


