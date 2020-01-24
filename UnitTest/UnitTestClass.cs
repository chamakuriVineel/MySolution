using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTest
{
    #region classes
    [TestClass]
    public class UnitTestClass
    {
        #region Methods
        #region DivisionTests
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
        #endregion DivisionTests
        #region AdditionTests
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
        #endregion AditionTests
        #region SubstractionTest
        [TestMethod]
        public void CheckSubstractionWithOverFlowCondition()
        {
            int a = 0;
            int b = int.MinValue;
            Assert.ThrowsException<System.OverflowException>(()=>Calculator.MathOperations.Substraction(a,b));
        }
        [TestMethod]
        public void CheckSubstractionWithCorrectArguments()
        {
            int a = 0;
            int b = int.MaxValue;
            Assert.AreEqual(-int.MaxValue, Calculator.MathOperations.Substraction(a, b), 0, "Not working as expected");
        }
        #endregion SubstractionTests
        #region MultiplicationTests
        [TestMethod]
        public void CheckMultilicationWithOverFlowCondition()
        {
            int a = int.MaxValue;
            int b = 2;
            Assert.ThrowsException<System.OverflowException>(()=>Calculator.MathOperations.Multiplication(a,b));
        }
        [TestMethod]
        public void CheckMultiplicationWithCorrectArguments()
        {
            int a = Calculator.MathOperations.Division(int.MaxValue , 2);
            int b = 2;
            Assert.AreEqual(int.MaxValue, Calculator.MathOperations.Multiplication(a, b), 0,"Not Working as expected");
        }
        #endregion MultiplicationTests
        #endregion Methods

    }
    #endregion classes
}
