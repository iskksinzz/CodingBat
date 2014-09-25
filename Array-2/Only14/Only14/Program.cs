using System;

namespace Only14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Only14(new[] { 1, 4, 1, 4 }));
            Console.WriteLine(Only14(new[] { 1, 4, 2, 4 }));
            Console.WriteLine(Only14(new[] { 1, 1 }));
            Console.ReadLine();
        }

        public static bool Only14(int[] nums)
        {
            foreach (var num in nums)
            {
                if (num != 1 && num != 4)
                    return false;
            }
            return true;
        }
    }
}
