using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class SquareRootOperatorUnitTests
    {
        private SquareRootOperator SquareRootOperator;
        private Stack<double> numStack;

        [TestInitialize]
        public void TestInitialize()
        {
            SquareRootOperator = new SquareRootOperator();
            numStack = new Stack<double>();
        }

        [TestMethod]
        public void SquareRootOfOneEqualsOneTestMethod()
        {
            numStack.Push(1);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void SquareRootOfZeroEqualsZeroTestMethod()
        {
            numStack.Push(0);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void SquareRootOfNineEqualsThreeTestMethod()
        {
            numStack.Push(9);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void SquareRootOfOneFortyFourEqualsTwelveTestMethod()
        {
            numStack.Push(144);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 12);
        }
    }
}

