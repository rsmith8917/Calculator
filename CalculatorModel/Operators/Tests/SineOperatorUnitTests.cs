using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class SineOperatorUnitTests
    {
        private SineOperator SineOperator;
        private Stack<double> numStack;

        [TestInitialize]
        public void TestInitialize()
        {
            SineOperator = new SineOperator();
            numStack = new Stack<double>();
        }

        [TestMethod]
        public void SineOfPIByTwoEqualsOneTestMethod()
        {
            numStack.Push(Math.PI/2);
            var result = SineOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void SineOfZeroEqualsZeroTestMethod()
        {
            numStack.Push(0);
            var result = SineOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void SineOfPIEqualsZeroTestMethod()
        {
            numStack.Push(Math.PI);
            var result = SineOperator.Operate(numStack);
            Assert.AreEqual(result, 0, 1e-8);
        }

        [TestMethod]
        public void SineOfTwoEqualsPointNineZeroNineTestMethod()
        {
            numStack.Push(2);
            var result = SineOperator.Operate(numStack);
            Assert.AreEqual(result, 0.90929742682568, 1e-8);
        }
    }
}

