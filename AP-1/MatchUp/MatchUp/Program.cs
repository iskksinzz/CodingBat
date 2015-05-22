using System;

namespace MatchUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MatchUp(new[] { "aa", "bb", "cc" }, new[] { "aaa", "xx", "bb" }));
            Console.WriteLine(MatchUp(new[] { "aa", "bb", "cc" }, new[] { "aaa", "b", "bb" }));
            Console.WriteLine(MatchUp(new[] { "aa", "bb", "cc" }, new[] { "", "", "ccc" }));
            Console.ReadLine();
        }

        private static int MatchUp(string[] a, string[] b)
        {
            var count = 0;
            for (var i = 0; i < a.Length; i++)
                if (!String.IsNullOrEmpty(a[i]) && !String.IsNullOrEmpty(b[i]))
                    if (a[i][0] == b[i][0])
                        count++;
            return count;
        }
    }
}
