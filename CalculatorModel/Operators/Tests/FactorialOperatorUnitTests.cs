﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class FactorialOperatorUnitTests
    {
        private FactorialOperator FactorialOperator;
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            FactorialOperator = new FactorialOperator();
            numStack = new Stack<double>();
        }

        [Test]
        public void FactorialOfOneEqualsOneTestMethod()
        {
            numStack.Push(1);
            var result = FactorialOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void FactorialOfZeroEqualsOneTestMethod()
        {
            numStack.Push(0);
            var result = FactorialOperator.Operate(numStack);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void FactorialOfNineEqualsThreeHundredSixtyTwoThousandTestMethod()
        {
            numStack.Push(9);
            var result = FactorialOperator.Operate(numStack);
            Assert.AreEqual(result, 362880);
        }

        [Test]
        public void FactorialOfFourPointThreeEqualsTwentyFourTestMethod()
        {
            numStack.Push(4.3);
            var result = FactorialOperator.Operate(numStack);
            Assert.AreEqual(result, 24);
        }

    }
}

