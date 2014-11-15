using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class SubtractionOperatorUnitTests
    {
        [TestMethod]
        public void TwoMinusOneEqualsOneTestMethod()
        {
            var SubtractionOperator = new SubtractionOperator();
            var numStack = new Stack<double>();
            numStack.Push(2);
            numStack.Push(1);
            var result = SubtractionOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ZeroMinusZeroEqualsZeroTestMethod()
        {
            var SubtractionOperator = new SubtractionOperator();
            var numStack = new Stack<double>();
            numStack.Push(0);
            numStack.Push(0);
            var result = SubtractionOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NegativeFiveMinusThreeEqualsNegativeEightTestMethod()
        {
            var SubtractionOperator = new SubtractionOperator();
            var numStack = new Stack<double>();
            numStack.Push(-5);
            numStack.Push(3);
            var result = SubtractionOperator.Operate(numStack);
            Assert.AreEqual(result, -8);
        }
    }
}

