﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___FrontTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FrontTimes("Chocolate", 2));
            Console.WriteLine(FrontTimes("Chocolate", 3));
            Console.WriteLine(FrontTimes("Abc", 3));
            Console.ReadLine();
        }

        /* Given a string and a non-negative int n, we'll say that the front of the string 
         * is the first 3 chars, or whatever is there if the string is less than length 3. 
         * Return n copies of the front; */

        public static string FrontTimes(string str, int n)
        {
            var result = string.Empty;
            var frontOfString = 3;

            if (frontOfString > str.Length)
                frontOfString = str.Length;

            var front = str.Substring(0, frontOfString);

            for (var i = 0; i < n; i++)
            {
                result += front;
            }
            return result;
        }
    }
}