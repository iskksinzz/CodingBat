using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZThere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XyzThere("abcxyz"));
            Console.WriteLine(XyzThere("abc.xyz"));
            Console.WriteLine(XyzThere("xyz.abc"));
            Console.ReadLine();
        }

        /* Return true if the given string contains an appearance of "xyz" where the xyz is not 
         * directly preceeded by a period (.). So "xxyz" counts but "x.xyz" does not.*/
        public static bool XyzThere(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                if (i <= str.Length - 3 && str.Substring(i, 3).Equals("xyz"))
                    if (i == 0)
                        return true;
                    else if (str[i - 1] != '.')
                        return true;
            }
            return false;
        }
    }
}
