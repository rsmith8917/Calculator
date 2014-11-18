using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class DivisionOperatorUnitTests
    {
        private DivisionOperator DivisionOperator;
        private Stack<double> numStack;

        [TestInitialize]
        public void TestInitialize()
        {
            DivisionOperator = new DivisionOperator();
            numStack = new Stack<double>();
        }

        [TestMethod]
        public void TwoDividedByOneEqualsTwoTestMethod()
        {
            numStack.Push(2);
            numStack.Push(1);
            var result = DivisionOperator.Operate(numStack);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ZeroDividedByZeroThrowsDivideByZeroExceptionTestMethod()
        {
            numStack.Push(0);
            numStack.Push(0);
            var result = DivisionOperator.Operate(numStack);
        }

        [TestMethod]
        public void NegativeFiveDividedByThreeEqualsNegativeOnePointSixSevenTestMethod()
        {
            numStack.Push(-5);
            numStack.Push(3);
            var result = DivisionOperator.Operate(numStack);
            Assert.AreEqual(result, -1.666666666666667, 1e-6);
        }
    }
}

