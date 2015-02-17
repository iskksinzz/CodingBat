using System;

namespace MaxMirror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxMirror(new[] { 1, 2, 3, 8, 9, 3, 2, 1 }));
            Console.WriteLine(MaxMirror(new[] { 1, 2, 1, 4 }));
            Console.WriteLine(MaxMirror(new[] { 7, 1, 2, 9, 7, 2, 1 }));

            Console.ReadLine();
        }

        public static int MaxMirror(int[] nums)
        {
            var max = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var k = 0;
                for (var j = nums.Length - 1; i + k < nums.Length && j >= 0; j--)
                {
                    if (nums[i + k] == nums[j])
                        k++;
                    else
                    {
                        if (k > 0)
                        {
                            max = Math.Max(k, max);
                            k = 0;
                        }
                    }
                }
                max = Math.Max(k, max);
            }
            return max;
        }
    }
}