using System;
using NUnit.Framework;
using _14___AreInOrder;

namespace AreInOrderTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(1, 2, 4, false, Result = true)]
        [TestCase(1, 2, 1, false, Result = false)]
        [TestCase(1, 1, 2, true, Result = true)]
        [TestCase(3, 2, 4, false, Result = false)]
        [TestCase(2, 3, 4, false, Result = true)]
        [TestCase(3, 2, 4, true, Result = true)]
        [TestCase(4, 2, 2, true, Result = false)]
        [TestCase(4, 5, 2, true, Result = false)]
        [TestCase(2, 4, 6, true, Result = true)]
        [TestCase(7, 9, 10, false, Result = true)]
        [TestCase(7, 5, 6, true, Result = true)]
        [TestCase(7, 5, 4, true, Result = false)]
        public bool TestAreInOrder(int a, int b, int c, bool tf)
        {
            return Program.AreInOrder(a, b, c, tf);
        }
    }
}
