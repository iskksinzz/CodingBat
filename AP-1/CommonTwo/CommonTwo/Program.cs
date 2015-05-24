using System;

namespace CommonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CommonTwo(new[] { "a", "c", "x" }, new[] { "b", "c", "d", "x" }));
            Console.WriteLine(CommonTwo(new[] { "a", "c", "x" }, new[] { "a", "b", "c", "x", "z" }));
            Console.WriteLine(CommonTwo(new[] { "a", "b", "c" }, new[] { "a", "b", "c" }));
            Console.ReadLine();
        }

        private static int CommonTwo(string[] a, string[] b)
        {
            var count = 0;
            var prev = string.Empty;
            foreach (var strA in a)
                foreach (var strB in b)
                    if (strA.Equals(strB) && strB != prev)
                    {
                        prev = strA;
                        count++;
                    }

            return count;
        }
    }
}
