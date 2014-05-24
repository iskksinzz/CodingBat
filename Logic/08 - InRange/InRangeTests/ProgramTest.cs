using System;
using _08___InRange;
using NUnit.Framework;

namespace InRangeTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(5, false, Result = true)]
        [TestCase(11, false, Result = false)]
        [TestCase(11, true, Result = true)]
        [TestCase(10, false, Result = true)]
        [TestCase(10, true, Result = true)]
        [TestCase(9, true, Result = false)]
        [TestCase(1, false, Result = true)]
        [TestCase(1, true, Result = true)]
        [TestCase(0, false, Result = false)]
        [TestCase(0, true, Result = true)]
        [TestCase(-1, false, Result = false)]
        public bool TestInRange(int n, bool b)
        {
            return Program.InRange(n, b);
        }
    }
}
