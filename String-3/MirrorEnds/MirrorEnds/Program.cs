using System;

namespace MirrorEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MirrorEnds("abXYZba"));
            Console.WriteLine(MirrorEnds("abca"));
            Console.WriteLine(MirrorEnds("aba"));
            Console.ReadLine();
        }

        private static string MirrorEnds(string str)
        {
            var s = "";
            for (var i = 0; i < str.Length; i++)
            {
                if (!str[i].Equals(str[str.Length - i - 1]))
                    break;
                s += str[i];
            }
            return s;
        }
    }
}
