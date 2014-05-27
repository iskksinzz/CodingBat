using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04___CaughtSpeeding;


namespace CaughtSpeedingTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void BirthdayTest()
        {
            const int speed = 65;
            const bool isBirthday = true;
            const int expected = 0;
            const string message = "Go shorty it's your birthday!";

            var actual = Program.CaughtSpeeding(speed, isBirthday);
            Assert.AreEqual(expected, actual, message);
        }

        [TestMethod]
        public void NotBirthdayTest()
        {
            const int speed = 65;
            const bool isBirthday = false;
            const int expected = 1;
            const string message = "Hey hey hey!";

            var actual = Program.CaughtSpeeding(speed, isBirthday);
            Assert.AreEqual(expected, actual, message);
        }

        [TestMethod]
        public void TooFastToFurious()
        {
            const int speed = 90;
            const bool isBirthday = true;
            const int expected = 2;
            const string message = "Move bi*** get out the way!";

            var actual = Program.CaughtSpeeding(speed, isBirthday);
            Assert.AreEqual(expected, actual, message);
        }
    }
}
