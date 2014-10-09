using System;

namespace Has12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Has12(new[] { 1, 3, 2 }));
            Console.WriteLine(Has12(new[] { 3, 1, 2 }));
            Console.WriteLine(Has12(new[] { 3, 1, 4, 5, 2 }));
            Console.ReadLine();
        }

        public static bool Has12(int[] nums)
        {
            var one = false;
            var two = false;
            foreach (var num in nums)
            {
                if (num == 1) one = true;
                if (num == 2 && one) two = true;
            }
            return two;
        }
    }
}
