using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class DivisionOperatorUnitTests
    {
        private DivisionOperator DivisionOperator;
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            DivisionOperator = new DivisionOperator();
            numStack = new Stack<double>();
        }

        [Test]
        public void TwoDividedByOneEqualsTwoTestMethod()
        {
            numStack.Push(2);
            numStack.Push(1);
            var result = DivisionOperator.Operate(numStack);
            Assert.AreEqual(result, 2);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ZeroDividedByZeroThrowsDivideByZeroExceptionTestMethod()
        {
            numStack.Push(0);
            numStack.Push(0);
            var result = DivisionOperator.Operate(numStack);
        }

        [Test]
        public void NegativeFiveDividedByThreeEqualsNegativeOnePointSixSevenTestMethod()
        {
            numStack.Push(-5);
            numStack.Push(3);
            var result = DivisionOperator.Operate(numStack);
            Assert.AreEqual(result, -1.666666666666667, 1e-6);
        }
    }
}

