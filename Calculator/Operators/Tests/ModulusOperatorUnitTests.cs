using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class ModulusOperatorUnitTests
    {
        [TestMethod]
        public void OneModTwoEqualsOneTestMethod()
        {
            var ModulusOperator = new ModulusOperator();
            var numStack = new Stack<double>();
            numStack.Push(1);
            numStack.Push(2);
            var result = ModulusOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ZeroModZeroEqualsNaNTestMethod()
        {
            var ModulusOperator = new ModulusOperator();
            var numStack = new Stack<double>();
            numStack.Push(0);
            numStack.Push(0);
            var result = ModulusOperator.Operate(numStack);
            Assert.IsTrue(double.IsNaN(result));
        }

        [TestMethod]
        public void EighteenModSevenEqualsFourTestMethod()
        {
            var ModulusOperator = new ModulusOperator();
            var numStack = new Stack<double>();
            numStack.Push(18);
            numStack.Push(7);
            var result = ModulusOperator.Operate(numStack);
            Assert.AreEqual(result, 4);
        }
    }
}

