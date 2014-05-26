using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___TwoIsOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoIsOne(1, 2, 3));
            Console.WriteLine(TwoIsOne(3, 1, 2));
            Console.WriteLine(TwoIsOne(3, 2, 2));
            Console.ReadLine();
        }

        /* Given three ints, a b c, return true if it is possible
         * to add two of the ints to get the third. */
        public static bool TwoIsOne(int a, int b, int c)
        {
            return (a + b == c) || (b + c == a) || (a + c == b);
        }
    }
}
