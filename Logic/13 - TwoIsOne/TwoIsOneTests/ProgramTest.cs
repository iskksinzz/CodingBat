using System;
using NUnit.Framework;
using _13___TwoIsOne;

namespace TwoIsOneTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(1, 2, 3, Result = true)]
        [TestCase(3, 1, 2, Result = true)]
        [TestCase(3, 2, 2, Result = false)]
        [TestCase(2, 3, 1, Result = true)]
        [TestCase(5, 3, -2, Result = true)]
        [TestCase(5, 3, -3, Result = false)]
        [TestCase(2, 5, 3, Result = true)]
        [TestCase(9, 5, 5, Result = false)]
        [TestCase(9, 4, 5, Result = true)]
        [TestCase(5, 4, 9, Result = true)]
        [TestCase(3, 3, 0, Result = true)]
        [TestCase(3, 3, 2, Result = false)]
        public bool TestTwoIsOne(int a, int b, int c)
        {
            return Program.TwoIsOne(a, b, c);
        }
    }
}
