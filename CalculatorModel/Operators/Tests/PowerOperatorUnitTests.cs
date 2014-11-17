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
        [TestMethod]
        public void OneRaisedToTheTwoEqualsOneTestMethod()
        {
            var PowerOperator = new PowerOperator();
            var numStack = new Stack<double>();
            numStack.Push(1);
            numStack.Push(2);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ZeroRaisedToTheZeroEqualsOneTestMethod()
        {
            var PowerOperator = new PowerOperator();
            var numStack = new Stack<double>();
            numStack.Push(0);
            numStack.Push(0);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void NegativeFiveRaisedToTheThreeEqualsNeagtiveOneTwentyFiveTestMethod()
        {
            var PowerOperator = new PowerOperator();
            var numStack = new Stack<double>();
            numStack.Push(-5);
            numStack.Push(3);
            var result = PowerOperator.Operate(numStack);
            Assert.AreEqual(result, -125);
        }
    }
}

