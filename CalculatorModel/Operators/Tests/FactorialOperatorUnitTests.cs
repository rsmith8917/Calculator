using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class FactorialOperatorUnitTests
    {
        private FactorialOperator FactorialOperator;
        private Stack<double> numStack;

        [TestInitialize]
        public void TestInitialize()
        {
            FactorialOperator = new FactorialOperator();
            numStack = new Stack<double>();
        }

        [TestMethod]
        public void FactorialOfOneEqualsOneTestMethod()
        {
            numStack.Push(1);
            var result = FactorialOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void FactorialOfZeroEqualsOneTestMethod()
        {
            numStack.Push(0);
            var result = FactorialOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void FactorialOfNineEqualsThreeHundredSixtyTwoThousandTestMethod()
        {
            numStack.Push(9);
            var result = FactorialOperator.Operate(numStack);
            Assert.AreEqual(result, 362880);
        }

        [TestMethod]
        public void FactorialOfFourPointThreeEqualsTwentyFourTestMethod()
        {
            numStack.Push(4.3);
            var result = FactorialOperator.Operate(numStack);
            Assert.AreEqual(result, 24);
        }

    }
}

