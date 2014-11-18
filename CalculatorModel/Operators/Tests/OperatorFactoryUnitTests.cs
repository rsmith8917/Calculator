using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Operators.Tests
{
    [TestClass]
    public class OperatorFactoryUnitTests
    {
        [TestMethod]
        public void OperatorFactoryCreateAdditionTestMethod()
        {
            var AdditionOperator = new AdditionOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("+").ToString(), AdditionOperator.ToString());
        }

        [TestMethod]
        public void OperatorFactoryCreateSubtractionTestMethod()
        {
            var SubtractionOperator = new SubtractionOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("-").ToString(), SubtractionOperator.ToString());
        }

        [TestMethod]
        public void OperatorFactoryCreateMultiplicationTestMethod()
        {
            var MultiplicationOperator = new MultiplicationOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("*").ToString(), MultiplicationOperator.ToString());
        }

        [TestMethod]
        public void OperatorFactoryCreateDivisionTestMethod()
        {
            var DivisionOperator = new DivisionOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("/").ToString(), DivisionOperator.ToString());
        }

        [TestMethod]
        public void OperatorFactoryCreateModulusTestMethod()
        {
            var ModulusOperator = new ModulusOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("%").ToString(), ModulusOperator.ToString());
        }

        [TestMethod]
        public void OperatorFactoryCreatePowerTestMethod()
        {
            var PowerOperator = new PowerOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("^").ToString(), PowerOperator.ToString());
        }

        [TestMethod]
        public void OperatorFactoryCreateSquareRootTestMethod()
        {
            var SquareRootOperator = new SquareRootOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("sqrt").ToString(), SquareRootOperator.ToString());
        }

        [TestMethod]
        public void OperatorFactoryCreateFactorialTestMethod()
        {
            var FactorialOperator = new FactorialOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("!").ToString(), FactorialOperator.ToString());
        }
 
    }
}

