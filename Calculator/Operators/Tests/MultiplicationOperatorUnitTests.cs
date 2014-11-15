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
        [TestMethod]
        public void TwoTimesOneEqualsTwoTestMethod()
        {
            var MultiplicationOperator = new MultiplicationOperator();
            var result = MultiplicationOperator.Operate(2, 1);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void ZeroTimesZeroEqualsZeroTestMethod()
        {
            var MultiplicationOperator = new MultiplicationOperator();
            var result = MultiplicationOperator.Operate(0, 0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NegativeFiveTimesThreeEqualsNegativeFifteenTestMethod()
        {
            var MultiplicationOperator = new MultiplicationOperator();
            var result = MultiplicationOperator.Operate(-5, 3);
            Assert.AreEqual(result, -15);
        }
    }
}

