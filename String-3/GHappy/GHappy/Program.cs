using System;

namespace GHappy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GHappy("xxggxx"));
            Console.WriteLine(GHappy("xxgxx"));
            Console.WriteLine(GHappy("xxggyygxx"));
            Console.ReadLine();
        }

        public static bool GHappy(string str)
        {
            var result = false;
            if (str == string.Empty) { return true; }
            for (var i = 1; i <= str.Length - 1; i++)
            {
                if (str[i] != 'g') continue;
                result = str[i - 1] == 'g' || i < str.Length - 1 && str[i + 1] == 'g';
            }
            return result;
        }
    }
}
