using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZipZap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ZipZap("zipXzap"));
            Console.WriteLine(ZipZap("zopzop"));
            Console.WriteLine(ZipZap("zzzopzop"));
            Console.WriteLine(ZipZap("zibzap"));
            Console.WriteLine(ZipZap("zip"));
            Console.WriteLine(ZipZap("zi"));
            Console.WriteLine(ZipZap("z"));
            Console.WriteLine(ZipZap(""));
            Console.WriteLine(ZipZap("zzp"));
            Console.WriteLine(ZipZap("abcppp"));
            Console.WriteLine(ZipZap("azbcppp"));
            Console.WriteLine(ZipZap("azbcpzpp"));
            Console.ReadLine();
        }

        /* Look for patterns like "zip" and "zap" in the string -- length-3, starting with 'z' and ending with 'p'. 
         * Return a string where for all such words, the middle letter is gone, so "zipXzap" yields "zpXzp". */
        public static string ZipZap(string str)
        {
            //Regex rx = new Regex(@"(z)(.{1})(p)");
            //return rx.Replace(str, match => match.ToString().Remove(1, 1));

            if (str.Length < 3) return str;
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z' && str[i + 2] == 'p')
                {
                    result += str.Substring(i, 1) + str.Substring(i + 2, 1);
                    i += 2;
                }
                else
                {
                    result += str.Substring(i, 1);
                }
            }
            return result;
        }
    }
}