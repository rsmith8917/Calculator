using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class AdditionOperatorUnitTests
    {
        [TestMethod]
        public void OnePlusTwoEqualsThreeTestMethod()
        {
            var AdditionOperator = new AdditionOperator();
            var result = AdditionOperator.Operate(1, 2);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void ZeroPlusZeroEqualsZeroTestMethod()
        {
            var AdditionOperator = new AdditionOperator();
            var result = AdditionOperator.Operate(0, 0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NegativeFivePlusThreeEqualsNeagtiveTwoTestMethod()
        {
            var AdditionOperator = new AdditionOperator();
            var result = AdditionOperator.Operate(-5, 3);
            Assert.AreEqual(result, -2);
        }
    }
}

