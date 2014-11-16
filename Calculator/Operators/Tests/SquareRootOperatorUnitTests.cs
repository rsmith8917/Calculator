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
        [TestMethod]
        public void SquareRootOfOneEqualsOneTestMethod()
        {
            var SquareRootOperator = new SquareRootOperator();
            var numStack = new Stack<double>();
            numStack.Push(1);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void SquareRootOfZeroEqualsZeroTestMethod()
        {
            var SquareRootOperator = new SquareRootOperator();
            var numStack = new Stack<double>();
            numStack.Push(0);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void SquareRootOfNineEqualsThreeTestMethod()
        {
            var SquareRootOperator = new SquareRootOperator();
            var numStack = new Stack<double>();
            numStack.Push(9);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void SquareRootOfOneFortyFourEqualsTwelveTestMethod()
        {
            var SquareRootOperator = new SquareRootOperator();
            var numStack = new Stack<double>();
            numStack.Push(144);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 12);
        }
    }
}

