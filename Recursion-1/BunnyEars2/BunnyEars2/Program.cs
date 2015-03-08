using System;

namespace BunnyEars2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(BunnyEars2(2));
            Console.ReadLine();
        }

        public static int BunnyEars2(int bunnies)
        {
            return bunnies == 0 ? 0 : bunnies % 2 == 0 ? 3 + BunnyEars2(bunnies - 1) : 2 + BunnyEars2(bunnies - 1);
        }
    }
}
