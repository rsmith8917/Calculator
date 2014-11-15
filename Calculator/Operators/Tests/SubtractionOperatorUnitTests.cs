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
            var result = SubtractionOperator.Operate(2, 1);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ZeroMinusZeroEqualsZeroTestMethod()
        {
            var SubtractionOperator = new SubtractionOperator();
            var result = SubtractionOperator.Operate(0, 0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NegativeFiveMinusThreeEqualsNegativeEightTestMethod()
        {
            var SubtractionOperator = new SubtractionOperator();
            var result = SubtractionOperator.Operate(-5, 3);
            Assert.AreEqual(result, -8);
        }
    }
}

