using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class PowerOperatorUnitTests
    {
        private PowerOperator PowerOperator;
        private Stack<double> numStack;

        [TestInitialize]
        public void TestInitialize()
        {
            PowerOperator = new PowerOperator();
            numStack = new Stack<double>();
        }

        [TestMethod]
        public void OneRaisedToTheTwoEqualsOneTestMethod()
        {
            numStack.Push(1);
            numStack.Push(2);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ZeroRaisedToTheZeroEqualsOneTestMethod()
        {
            numStack.Push(0);
            numStack.Push(0);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void NegativeFiveRaisedToTheThreeEqualsNeagtiveOneTwentyFiveTestMethod()
        {
            numStack.Push(-5);
            numStack.Push(3);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, -125);
        }
    }
}

