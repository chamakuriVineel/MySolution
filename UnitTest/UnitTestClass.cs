using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTest
{
    [TestClass]
    public class UnitTestClass
    {
        [TestMethod]
        public void checkDivisionWithZero()
        {
            Assert.ThrowsException<System.DivideByZeroException>(() => Calculator.MathOperations.Division(5, 0));
        }
        [TestMethod]
        public void CheckDivisionWithCorrectArguments()
        {
            int a = 10098;
            int b = 2;
            int expected = 5049;
            Assert.AreEqual(expected,Calculator.MathOperations.Division(a,b),0,"Not working as expected");
        }
        [TestMethod]
        public void CheckAdditionWithOverFlowCondition()
        {
            int a = -int.MaxValue;
            int b = -2;
            Assert.ThrowsException<System.OverflowException>(()=>Calculator.MathOperations.Addition(a,b));
        }
        [TestMethod]
        public void CheckAdditionWithCorrectArguments()
        {
            int a = int.MaxValue - 1;
            int b = 1;
            int expected = int.MaxValue;
            Assert.AreEqual(expected,Calculator.MathOperations.Addition(a,b),"NotWorking as expected");
        }
    }
}
