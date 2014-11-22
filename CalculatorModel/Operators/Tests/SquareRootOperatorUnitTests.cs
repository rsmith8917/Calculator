using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class SquareRootOperatorUnitTests
    {
        private SquareRootOperator SquareRootOperator;
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            SquareRootOperator = new SquareRootOperator();
            numStack = new Stack<double>();
        }

        [Test]
        public void SquareRootOfOneEqualsOneTestMethod()
        {
            numStack.Push(1);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void SquareRootOfZeroEqualsZeroTestMethod()
        {
            numStack.Push(0);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void SquareRootOfNineEqualsThreeTestMethod()
        {
            numStack.Push(9);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void SquareRootOfOneFortyFourEqualsTwelveTestMethod()
        {
            numStack.Push(144);
            var result = SquareRootOperator.Operate(numStack);
            Assert.AreEqual(result, 12);
        }
    }
}

