using System;
using NUnit.Framework;
using _09___SpecialEleven;
namespace SpecialElevenTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(22, Result = true)]
        [TestCase(23, Result = true)]
        [TestCase(24, Result = false)]
        [TestCase(21, Result = false)]
        [TestCase(11, Result = true)]
        [TestCase(12, Result = true)]
        [TestCase(10, Result = false)]
        [TestCase(9, Result = false)]
        [TestCase(8, Result = false)]
        [TestCase(0, Result = true)]
        [TestCase(1, Result = true)]
        [TestCase(2, Result = false)]
        [TestCase(121, Result = true)]
        [TestCase(122, Result = true)]
        [TestCase(123, Result = false)]
        [TestCase(46, Result = false)]
        [TestCase(49, Result = false)]
        [TestCase(52, Result = false)]
        [TestCase(54, Result = false)]
        [TestCase(55, Result = true)]
        public bool TestSpecialEleven(int n)
        {
            return Program.SpecialEleven(n);
        }
    }
}
