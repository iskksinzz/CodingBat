using System;

namespace MergeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MergeTwo(new[] { "a", "c", "z" }, new[] { "b", "f", "z" }, 3));
            Console.WriteLine(MergeTwo(new[] { "a", "c", "z" }, new[] { "c", "f", "z" }, 3));
            Console.WriteLine(MergeTwo(new[] { "f", "g", "z" }, new[] { "c", "f", "g" }, 3));
            Console.ReadLine();
        }

        private static string[] MergeTwo(string[] a, string[] b, int n)
        {
            var arr = new string[n];
            int aCount = 0,
                bCount = 0;
            for (var i = 0; i < n; i++)
            {
                if (String.Compare(a[aCount], b[bCount], StringComparison.Ordinal) < 0)
                    arr[i] = a[aCount++];
                else if (a[aCount].Equals(b[bCount]))
                {
                    arr[i] = a[aCount++];
                    bCount++;
                }
                else
                    arr[i] = b[bCount++];
            }
            return arr;
        }

    }
}
