using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01___GreatParty;
using UnitTestGreatParty;

namespace UnitTestGreatParty
{
    [TestClass]
    public class GreatPartyTest
    {
        [TestMethod]
        public void NotSuccessfulPartyTest()
        {
            // arrange
            const int cigars = 30;
            const bool isWeekend = false;
            const bool expected = false;
            const string message = "Not a successful party!";

            // act & assert
            var actual = Program.GreatParty(cigars, isWeekend);
            Assert.AreEqual(expected, actual, message);
        }

        [TestMethod]
        public void SuccessfulPartyTest()
        {
            const int cigars = 50;
            const bool isWeekend = false;
            const bool expected = true;
            const string message = "Should be a successful party!";

            var actual = Program.GreatParty(cigars, isWeekend);
            Assert.AreEqual(expected, actual, message);
        }

        [TestMethod]
        public void IsWeekendTest()
        {
            const int cigars = 70;
            const bool isWeekend = true;
            const bool expected = true;
            const string message = "No limits in the weekends!";

            var actual = Program.GreatParty(cigars, isWeekend);
            Assert.AreEqual(expected, actual, message);
        }
    }
}
