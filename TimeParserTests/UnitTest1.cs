using NUnit.Framework;
using System;
using TimeZoneConverter;

namespace TimeParserTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("6pm", "CST")]
        public void TestTime(string time, string timezone, string localtimezone)
        {
            //DateTime.Parseut
            Assert.Pass();
        }

        [Test]
        public void ScratchPad()
        {
            var tzs = TimeZoneInfo.GetSystemTimeZones();

            //TimeZoneInfo tzi = TZConvert.GetTimeZoneInfo("Samoa");
            //Console.WriteLine(tzi);
            var t = DateTime.Parse("5pm");
            
            var tz = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            Console.WriteLine(tz);

            var dt = DateTimeOffset.Parse("5pm Pacific Standard Time");
            //TimeZoneInfo.ConvertTime()
                
            t.ToUniversalTime();
        }
    }
}