using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class ModulusOperatorUnitTests
    {
        private ModulusOperator ModulusOperator;
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            ModulusOperator = new ModulusOperator();
            numStack = new Stack<double>();
        }

        [Test]
        public void OneModTwoEqualsOneTestMethod()
        {
            numStack.Push(1);
            numStack.Push(2);
            var result = ModulusOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void ZeroModZeroEqualsNaNTestMethod()
        {
            numStack.Push(0);
            numStack.Push(0);
            var result = ModulusOperator.Operate(numStack);
            Assert.IsTrue(double.IsNaN(result));
        }

        [Test]
        public void EighteenModSevenEqualsFourTestMethod()
        {
            numStack.Push(18);
            numStack.Push(7);
            var result = ModulusOperator.Operate(numStack);
            Assert.AreEqual(result, 4);
        }
    }
}

