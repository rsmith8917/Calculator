using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class DivisionOperatorUnitTests
    {
        [TestMethod]
        public void TwoDividedByOneEqualsTwoTestMethod()
        {
            var DivisionOperator = new DivisionOperator();
            var result = DivisionOperator.Operate(2, 1);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ZeroDividedByZeroThrowsDivideByZeroExceptionTestMethod()
        {
            var DivisionOperator = new DivisionOperator();
            var result = DivisionOperator.Operate(0, 0);
        }

        [TestMethod]
        public void NegativeFiveDividedByThreeEqualsNegativeOnePointSixSevenTestMethod()
        {
            var DivisionOperator = new DivisionOperator();
            var result = DivisionOperator.Operate(-5, 3);
            Assert.AreEqual(result, -1.666666666666667, 1e-6);
        }
    }
}

