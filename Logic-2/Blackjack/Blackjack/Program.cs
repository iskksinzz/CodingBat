using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Blackjack(19, 21));
            Console.WriteLine(Blackjack(21, 19));
            Console.WriteLine(Blackjack(19, 22));
            Console.ReadLine();
        }

        public static int Blackjack(int a, int b)
        {
            return a > 21 && b > 21 ? 0 : ((21 - a < 21 - b) && (a < 22) ? a : (b < 22 ? b : a));
        }
    }
}
