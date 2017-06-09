using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OS_FinalProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            int day = 2;
            double expected = 200;
            var test1 = new PerDayRental(day);

            // act
            double actual = test1.calculate_revenue();

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            int kilometres = 20;
            double expected = 20;
            var test1 = new PerKmRental(kilometres);

            // act
            double actual = test1.calculate_revenue();

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
