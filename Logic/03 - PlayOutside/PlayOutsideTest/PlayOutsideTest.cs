using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03___PlayOutside;

namespace PlayOutsideTest
{
    [TestClass]
    public class PlayOutsideTest
    {
        [TestMethod]
        public void ChildrenPlay()
        {
            const int temperature = 60;
            const bool isSummer = false;
            const bool expected = true;
            const string message = "The children should play outside. It's sunny!";

            var actual = Program.PlayOutside(temperature, isSummer);

            Assert.AreEqual(expected, actual, message);
        }

        [TestMethod]
        public void IsSummer()
        {
            const int temperature = 100;
            const bool isSummer = true;
            const bool expected = true;
            const string message = "It's summer and the limit is 100.";

            var actual = Program.PlayOutside(temperature, isSummer);
            Assert.AreEqual(expected, actual, message);
        }

        [TestMethod]
        public void IsNotSummer()
        {
            const int temperature = 95;
            const bool isSummer = false;
            const bool expected = false;
            const string message = "It's not summer and the limit is 90.";

            var actual = Program.PlayOutside(temperature, isSummer);
            Assert.AreEqual(expected, actual, message);
        }
    }
}
