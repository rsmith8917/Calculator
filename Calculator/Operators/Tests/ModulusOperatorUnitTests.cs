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
            var result = ModulusOperator.Operate(1, 2);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ZeroModZeroEqualsNaNTestMethod()
        {
            var ModulusOperator = new ModulusOperator();
            var result = ModulusOperator.Operate(0, 0);
            Assert.IsTrue(double.IsNaN(result));
        }

        [TestMethod]
        public void EighteenModSevenEqualsFourTestMethod()
        {
            var ModulusOperator = new ModulusOperator();
            var result = ModulusOperator.Operate(18, 7);
            Assert.AreEqual(result, 4);
        }
    }
}

