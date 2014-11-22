using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class AdditionOperatorUnitTests
    {
        private AdditionOperator AdditionOperator;
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            AdditionOperator = new AdditionOperator();
            numStack = new Stack<double>();
        }

        [Test]
        public void OnePlusTwoEqualsThreeTestMethod()
        {
            numStack.Push(1);
            numStack.Push(2);
            var result = AdditionOperator.Operate(numStack);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void ZeroPlusZeroEqualsZeroTestMethod()
        {
            numStack.Push(0);
            numStack.Push(0);
            var result = AdditionOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void NegativeFivePlusThreeEqualsNeagtiveTwoTestMethod()
        {
            numStack.Push(-5);
            numStack.Push(3);
            var result = AdditionOperator.Operate(numStack);
            Assert.AreEqual(result, -2);
        }
    }
}

