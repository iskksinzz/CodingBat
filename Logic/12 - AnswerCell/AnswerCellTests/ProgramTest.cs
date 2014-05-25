using System;
using NUnit.Framework;
using _12___AnswerCell;

namespace AnswerCellTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(false, false, false, Result = true)]
        [TestCase(false, false, true, Result = false)]
        [TestCase(true, false, false, Result = false)]
        [TestCase(true, true, false, Result = true)]
        [TestCase(false, true, false, Result = true)]
        [TestCase(true, true, true, Result = false)]
        public bool TestAnswerCell(bool b, bool n, bool m)
        {
            return Program.AnswerCell(b, n, m);
        }
    }
}
