using System;
using NUnit.Framework;
using _17___RollDice;

namespace RollDiceTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(2, 3, true, Result = 5)]
        [TestCase(3, 3, true, Result = 7)]
        [TestCase(3, 3, false, Result = 6)]
        [TestCase(2, 3, false, Result = 5)]
        [TestCase(5, 4, true, Result = 9)]
        [TestCase(5, 4, false, Result = 9)]
        [TestCase(5, 5, true, Result = 11)]
        [TestCase(5, 5, false, Result = 10)]
        [TestCase(6, 6, true, Result = 7)]
        [TestCase(6, 6, false, Result = 12)]
        [TestCase(1, 6, true, Result = 7)]
        [TestCase(6, 1, false, Result = 7)]
        public int TestRollDice(int a, int b, bool tf)
        {
            return Program.RollDice(a, b, tf);
        }
    }
}
