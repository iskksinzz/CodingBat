using System;

namespace UserCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UserCompare("bb", 1, "zz", 2));
            Console.WriteLine(UserCompare("bb", 1, "aa", 2));
            Console.WriteLine(UserCompare("bb", 1, "bb", 1));
            Console.ReadLine();
        }

        private static int UserCompare(string aName, int aId, string bName, int bId)
        {
            if (String.Compare(aName, bName, StringComparison.Ordinal) < 0) return -1;
            if (aName.Equals(bName))
            {
                if (aId == bId) { return 0; }
                if (bId > aId) { return -1; }
            }
            return 1;
        }
    }
}
