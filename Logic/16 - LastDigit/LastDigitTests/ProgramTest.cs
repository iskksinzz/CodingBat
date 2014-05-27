using System;
using NUnit.Framework;
using _16___LastDigit;

namespace LastDigitTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(23, 19, 13, Result = true)]
        [TestCase(23, 19, 12, Result = false)]
        [TestCase(23, 19, 3, Result = true)]
        [TestCase(23, 19, 39, Result = true)]
        [TestCase(1, 2, 3, Result = false)]
        [TestCase(1, 1, 2, Result = true)]
        [TestCase(1, 2, 2, Result = true)]
        [TestCase(14, 25, 43, Result = false)]
        [TestCase(14, 25, 45, Result = true)]
        [TestCase(248, 106, 1002, Result = false)]
        [TestCase(248, 106, 1008, Result = true)]
        [TestCase(10, 11, 20, Result = true)]
        [TestCase(0, 11, 0, Result = true)]
        public bool TestLastDigit(int a, int b, int c)
        {
            return Program.LastDigit(a, b, c);
        }
    }
}
