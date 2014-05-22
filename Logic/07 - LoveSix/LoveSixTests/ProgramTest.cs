using System;
using NUnit.Framework;
using _07___LoveSix;

namespace LoveSixTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(6, 4, Result = true)]
        [TestCase(4, 5, Result = false)]
        [TestCase(1, 5, Result = true)]
        [TestCase(1, 6, Result = true)]
        [TestCase(1, 8, Result = false)]
        [TestCase(1, 7, Result = true)]
        [TestCase(7, 5, Result = false)]
        [TestCase(8, 2, Result = true)]
        [TestCase(6, 6, Result = true)]
        [TestCase(-6, 2, Result = false)]
        [TestCase(-4, -10, Result = true)]
        [TestCase(-7, 1, Result = false)]
        [TestCase(7, -1, Result = true)]
        [TestCase(-6, 12, Result = true)]
        [TestCase(-2, -4, Result = false)]
        [TestCase(7, 1, Result = true)]
        [TestCase(0, 9, Result = false)]
        [TestCase(8, 3, Result = false)]
        [TestCase(3, 3, Result = true)]
        [TestCase(3, 4, Result = false)]
        public bool TestLoveSix(int a, int b)
        {
            return Program.LoveSix(a, b);
        }
    }
}
