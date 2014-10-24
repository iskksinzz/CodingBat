using System;

namespace MakeBricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeBricks(3, 1, 8));
            Console.WriteLine(MakeBricks(3, 1, 9));
            Console.WriteLine(MakeBricks(3, 2, 10));
            Console.ReadLine();
        }

        public static bool MakeBricks(int small, int big, int goal)
        {
            return !(goal > big * 5 + small) && !(goal % 5 > small);
        }
    }
}
