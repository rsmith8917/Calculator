using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class PowerOperatorUnitTests
    {
        private PowerOperator PowerOperator;
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            PowerOperator = new PowerOperator();
            numStack = new Stack<double>();
        }

        [Test]
        public void OneRaisedToTheTwoEqualsOneTestMethod()
        {
            numStack.Push(1);
            numStack.Push(2);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void ZeroRaisedToTheZeroEqualsOneTestMethod()
        {
            numStack.Push(0);
            numStack.Push(0);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void NegativeFiveRaisedToTheThreeEqualsNeagtiveOneTwentyFiveTestMethod()
        {
            numStack.Push(-5);
            numStack.Push(3);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, -125);
        }
    }
}

