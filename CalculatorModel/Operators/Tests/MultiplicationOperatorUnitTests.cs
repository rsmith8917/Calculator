using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class MultiplicationOperatorUnitTests
    {
        private MultiplicationOperator MultiplicationOperator;
        private Stack<double> numStack;

        [TestInitialize]
        public void TestInitialize()
        {
            MultiplicationOperator = new MultiplicationOperator();
            numStack = new Stack<double>();
        }

        [TestMethod]
        public void TwoTimesOneEqualsTwoTestMethod()
        {
            numStack.Push(2);
            numStack.Push(1);
            var result = MultiplicationOperator.Operate(numStack);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void ZeroTimesZeroEqualsZeroTestMethod()
        {
            numStack.Push(0);
            numStack.Push(0);
            var result = MultiplicationOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NegativeFiveTimesThreeEqualsNegativeFifteenTestMethod()
        {
            numStack.Push(-5);
            numStack.Push(3);
            var result = MultiplicationOperator.Operate(numStack);
            Assert.AreEqual(result, -15);
        }
    }
}

