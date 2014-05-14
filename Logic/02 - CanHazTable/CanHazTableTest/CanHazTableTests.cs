using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02___CanHazTable;

namespace CanHazTableTest
{
    [TestClass]
    public class CanHazTableTests
    {
        [TestMethod]
        public void TestNotStylish()
        {
            const int yourStyle = 8;
            const int dateStyle = 2;
            const int expected = 0;
            const string message = "No table for you folks!";

            var actual = Program.CanHazTable(yourStyle, dateStyle);
            Assert.AreEqual(expected, actual, message);
        }

        [TestMethod]
        public void TestStylish()
        {
            const int yourStyle = 8;
            const int dateStyle = 3;
            const int expected = 2;
            const string message = "You're pretty stylish today! Pick a table.";

            var actual = Program.CanHazTable(yourStyle, dateStyle);
            Assert.AreEqual(expected, actual, message);
        }

        [TestMethod]
        public void TestMaybeStylish()
        {
            const int yourStyle = 7;
            const int dateStyle = 5;
            const int expected = 1;
            const string message = "You might get a table.";

            var actual = Program.CanHazTable(yourStyle, dateStyle);
            Assert.AreEqual(expected, actual, message);
        }
    }
}