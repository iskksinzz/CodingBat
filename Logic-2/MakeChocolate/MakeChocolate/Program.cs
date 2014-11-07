using System;

namespace MakeChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeChocolate(4, 1, 9));
            Console.WriteLine(MakeChocolate(4, 1, 10));
            Console.WriteLine(MakeChocolate(4, 1, 7));
            Console.ReadLine();
        }

        public static int MakeChocolate(int small, int big, int goal)
        {
            var n = goal - Math.Min(big, goal / 5) * 5;
            return (n <= small) ? n : -1;
        }
    }
}

