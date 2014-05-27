using System;
using NUnit.Framework;
using _10___Mod20;

namespace Mod20Tests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(20, Result = false)]
        [TestCase(21, Result = true)]
        [TestCase(22, Result = true)]
        [TestCase(23, Result = false)]
        [TestCase(25, Result = false)]
        [TestCase(30, Result = false)]
        [TestCase(31, Result = false)]
        [TestCase(59, Result = false)]
        [TestCase(60, Result = false)]
        [TestCase(61, Result = true)]
        [TestCase(62, Result = true)]
        [TestCase(1020, Result = false)]
        [TestCase(1021, Result = true)]
        [TestCase(1000, Result = false)]
        [TestCase(1001, Result = true)]
        [TestCase(50, Result = false)]
        [TestCase(55, Result = false)]
        [TestCase(40, Result = false)]
        [TestCase(41, Result = true)]
        [TestCase(39, Result = false)]
        [TestCase(42, Result = true)]
        public bool TestMod20(int n)
        {
            return Program.Mod20(n);
        }
    }
}
