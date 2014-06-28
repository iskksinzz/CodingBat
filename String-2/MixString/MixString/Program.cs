using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MixString("abc", "xyz"));
            Console.WriteLine(MixString("Hi", "There"));
            Console.WriteLine(MixString("xxxx", "There"));
            Console.ReadLine();
        }

        public static string MixString(string a, string b)
        {
            var result = string.Empty;
            var len = b.Length;
            var chars = b.Length - a.Length;

            if (a.Length > b.Length)
            {
                len = a.Length;
                chars = a.Length - b.Length;
            }

            for (var i = 0; i < len; i++)
            {
                if (i >= len - chars && a.Length != b.Length)
                {
                    if (a.Length > b.Length)
                        result += a.Substring(a.Length - chars);
                    else
                        result += b.Substring(b.Length - chars);
                    break;
                }
                result += a.Substring(i, 1) + b.Substring(i, 1);
            }
            return result;
        }
    }
}
