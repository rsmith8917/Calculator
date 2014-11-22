using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class SubtractionOperatorUnitTests
    {
        private SubtractionOperator SubtractionOperator;
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            SubtractionOperator = new SubtractionOperator();
            numStack = new Stack<double>();
        }

        [Test]
        public void TwoMinusOneEqualsOneTestMethod()
        {
            numStack.Push(2);
            numStack.Push(1);
            var result = SubtractionOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void ZeroMinusZeroEqualsZeroTestMethod()
        {
            numStack.Push(0);
            numStack.Push(0);
            var result = SubtractionOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void NegativeFiveMinusThreeEqualsNegativeEightTestMethod()
        {
            numStack.Push(-5);
            numStack.Push(3);
            var result = SubtractionOperator.Operate(numStack);
            Assert.AreEqual(result, -8);
        }
    }
}

