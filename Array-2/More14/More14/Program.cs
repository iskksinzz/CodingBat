using System;

namespace More14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(More14(new[] { 1, 4, 1 }));
            Console.WriteLine(More14(new[] { 1, 4, 1, 4 }));
            Console.WriteLine(More14(new[] { 1, 1 }));
            Console.ReadLine();
        }

        public static bool More14(int[] nums)
        {
            var o = 0;
            var f = 0;
            foreach (var i in nums)
            {
                if (i == 1) o++;
                if (i == 4) f++;
            }
            return o > f;
        }
    }
}
