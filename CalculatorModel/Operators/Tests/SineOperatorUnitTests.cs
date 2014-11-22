using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class SineOperatorUnitTests
    {
        private SineOperator SineOperator;
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            SineOperator = new SineOperator();
            numStack = new Stack<double>();
        }

        [Test]
        public void SineOfPIByTwoEqualsOneTestMethod()
        {
            numStack.Push(Math.PI/2);
            var result = SineOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void SineOfZeroEqualsZeroTestMethod()
        {
            numStack.Push(0);
            var result = SineOperator.Operate(numStack);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void SineOfPIEqualsZeroTestMethod()
        {
            numStack.Push(Math.PI);
            var result = SineOperator.Operate(numStack);
            Assert.AreEqual(result, 0, 1e-8);
        }

        [Test]
        public void SineOfTwoEqualsPointNineZeroNineTestMethod()
        {
            numStack.Push(2);
            var result = SineOperator.Operate(numStack);
            Assert.AreEqual(result, 0.90929742682568, 1e-8);
        }
    }
}

