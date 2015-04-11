using System;

namespace ChangeXY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChangeXY("codex"));
            Console.WriteLine(ChangeXY("xxhixx"));
            Console.WriteLine(ChangeXY("xhixhix"));
            Console.ReadLine();
        }

        private static string ChangeXY(string str)
        {
            if (str.Length < 1)
                return str;
            var front = str[0] == 'x' ? 'y' : str[0];
            return front + ChangeXY(str.Substring(1));
        }
    }
}
