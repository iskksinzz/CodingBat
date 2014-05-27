using System;
using _15___InOrderEqual;
using NUnit.Framework;

namespace InOrderEqualTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(2, 5, 11, false, Result = true)]
        [TestCase(5, 7, 6, false, Result = false)]
        [TestCase(5, 5, 7, true, Result = true)]
        [TestCase(5, 5, 7, false, Result = false)]
        [TestCase(2, 5, 4, false, Result = false)]
        [TestCase(3, 4, 3, false, Result = false)]
        [TestCase(3, 4, 4, false, Result = false)]
        [TestCase(3, 4, 3, true, Result = false)]
        [TestCase(3, 4, 4, true, Result = true)]
        [TestCase(1, 5, 5, true, Result = true)]
        [TestCase(5, 5, 5, true, Result = true)]
        [TestCase(2, 2, 1, true, Result = false)]
        [TestCase(9, 2, 2, true, Result = false)]
        [TestCase(0, 1, 0, true, Result = false)]
        public bool TestInOrderEqual(int a, int b, int c, bool tf)
        {
            return Program.InOrderEqual(a, b, c, tf);
        }
    }
} 