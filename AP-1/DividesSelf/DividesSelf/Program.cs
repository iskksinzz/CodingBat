using System;

namespace DividesSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DividesSelf(128));
            Console.WriteLine(DividesSelf(12));
            Console.WriteLine(DividesSelf(120));
            Console.ReadLine();
        }

        private static bool DividesSelf(int n)
        {
            var val = n;
            while (val > 0)
            {
                if (val % 10 == 0 || n % (val % 10) != 0)
                    return false;
                val /= 10;
            }
            return true;
        }
    }
}