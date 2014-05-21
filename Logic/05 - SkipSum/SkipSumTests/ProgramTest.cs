using System;
using NUnit.Framework;
using _05___SkipSum;

namespace SkipSumTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(3,4, Result = 7)]
        [TestCase(9,4, Result = 20)]
        [TestCase(10,11, Result = 21)]
        [TestCase(12,-3, Result = 9)]
        [TestCase(-3,12, Result = 9)]
        [TestCase(4,5, Result = 9)]
        [TestCase(4,6, Result = 20)]
        [TestCase(14,7, Result = 21)]
        [TestCase(14,6, Result = 20)]
        [TestCase(10,9, Result = 20)]
        public int TestMethod(int a, int b)
        {
            return Program.SkipSum(a, b);
        }
    }
}
