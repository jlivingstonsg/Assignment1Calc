using System;
using System.Globalization;
using Xunit;

namespace Assignment1Calc.Tests
{
    /// </summary>
    public class UnitTest1
    {
        // Initialize instance of Calc so it can be use inside UnitTest1
        private static  Calc calc = new Calc();

        // Tests that have to be runned with multiple datasets should be given the [Theory] attribute.
        [Theory]
        [InlineData(7, 5, 2)]
        [InlineData(7, 2, 5)]
        [InlineData(-4, -6, 2)]
        public void TestSum(int expected, int firstnumber, int lastnumber)
        {
            int actual = calc.SumSub(firstnumber, lastnumber);
            // This tests if the actual result is suppose to equal the expected result. If not, the test will fail.
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 10, 5)]
        [InlineData(-19, -12.0, 7)]
        [InlineData(-5, 7, 12)]
        [InlineData(14.5, 9.2, -5.3)]
        public void TestSub(double expected, double firstnumber, double lastnumber)
        {
            double actual = calc.SumSub(firstnumber, lastnumber);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-84, -12, 7)]
        [InlineData(12, -3, -4)]
        public void TestMult(double expected, double firstnumber, double lastnumber)
        {
            double actual = calc.Mult(firstnumber, lastnumber);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0.4, 2, 5)]
        [InlineData(-2, -12, 6)]
        [InlineData(3, -12, -4)]
        public void TestDivNotDividedByZero(double expected, double firstnumber, double lastnumber)
        {
            double actual = calc.Div(firstnumber, lastnumber);
            Assert.Equal(expected, actual);
        }

        // For tests that do not need to multiple datasets should be given the attribute [Fact]
        [Fact]
        public void TestDivDividedByZero()
        {
            // This test if calc.Div(4, 0) thorws an exception
            Assert.Throws<Exception>(() => calc.Div(4, 0));
        }

    }//  public class UnitTest1

}//  namespace Assignment1Calc.Tests
