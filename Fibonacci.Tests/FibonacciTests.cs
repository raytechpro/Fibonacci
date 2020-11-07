using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;

namespace Fibonacci.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void Should_Return_CorrectResult_When_nthTerm_Is_0()
        {
            const int nthTerm = 0;
            BigInteger expectedResult = 0;

            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "nth Term must be 0 or greater.")]
        public void Should_Throw_Exception_When_nthTerm_Is_LessThan_0()
        {
            const int nthTerm = -1;
            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);
        }

        [TestMethod]
        public void Should_Return_CorrectResult_When_nthTerm_Is_1()
        {
            const int nthTerm = 1;
            BigInteger expectedResult = 0;

            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Should_Return_CorrectResult_When_nthTerm_Is_2()
        {
            const int nthTerm = 2;
            BigInteger expectedResult = 1;

            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Should_Return_CorrectResult_When_nthTerm_Is_3()
        {
            const int nthTerm = 3;
            BigInteger expectedResult = 2;

            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Should_Return_CorrectResult_When_nthTerm_Is_10()
        {
            const int nthTerm = 10;
            BigInteger expectedResult = 55;

            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Should_Return_CorrectResult_When_nthTerm_Is_100()
        {
            const int nthTerm = 100;
            BigInteger expectedResult = BigInteger.Parse("354224848179261915075");

            BigInteger result = Fibonacci.CalculateFibonacci(nthTerm);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
