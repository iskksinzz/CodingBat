using System;
using NUnit.Framework;
using _11___Mod35;

namespace Mod35Tests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(3, Result = true)]
        [TestCase(10, Result = true)]
        [TestCase(15, Result = false)]
        [TestCase(5, Result = true)]
        [TestCase(9, Result = true)]
        [TestCase(8, Result = false)]
        [TestCase(7, Result = false)]
        [TestCase(6, Result = true)]
        [TestCase(17, Result = false)]
        [TestCase(18, Result = true)]
        [TestCase(29, Result = false)]
        [TestCase(20, Result = true)]
        [TestCase(21, Result = true)]
        [TestCase(22, Result = false)]
        [TestCase(45, Result = false)]
        [TestCase(99, Result = true)]
        public bool TestMod35(int n)
        {
            return Program.Mod35(n);
        }
    }
}
