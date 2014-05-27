using System;
using _06___AlarmClock;
using NUnit.Framework;
namespace AlarmClockTests
{
    [TestFixture]
    public class ProgramTest
    {
        [TestCase(1, false, Result = "7:00")]
        [TestCase(5, false, Result = "7:00")]
        [TestCase(0, false, Result = "10:00")]
        [TestCase(6, false, Result = "10:00")]
        [TestCase(0, true, Result = "off")]
        [TestCase(6, true, Result = "off")]
        [TestCase(1, true, Result = "10:00")]
        [TestCase(3, true, Result = "10:00")]
        [TestCase(5, true, Result = "10:00")]
        public string TestAlarmClock(int day, bool vacation)
        {
            return Program.AlarmClock(day, vacation);
        }
    }
}
