using System;

namespace BunnyEars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BunnyEars(2));
            Console.ReadLine();
        }

        public static int BunnyEars(int bunnies)
        {
            return bunnies * 2;
        }

    }
}
