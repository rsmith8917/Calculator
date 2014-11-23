using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class OperatorFactoryUnitTests
    {
        [Test]
        public void OperatorFactoryCreateAdditionTestMethod()
        {
            var AdditionOperator = new AdditionOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("+").ToString(), AdditionOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateSubtractionTestMethod()
        {
            var SubtractionOperator = new SubtractionOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("-").ToString(), SubtractionOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateMultiplicationTestMethod()
        {
            var MultiplicationOperator = new MultiplicationOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("*").ToString(), MultiplicationOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateDivisionTestMethod()
        {
            var DivisionOperator = new DivisionOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("/").ToString(), DivisionOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateModulusTestMethod()
        {
            var ModulusOperator = new ModulusOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("%").ToString(), ModulusOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreatePowerTestMethod()
        {
            var PowerOperator = new PowerOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("^").ToString(), PowerOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateSquareRootTestMethod()
        {
            var SquareRootOperator = new SquareRootOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("sqrt").ToString(), SquareRootOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateFactorialTestMethod()
        {
            var FactorialOperator = new FactorialOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("!").ToString(), FactorialOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateSineTestMethod()
        {
            var SineOperator = new SineOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("sin").ToString(), SineOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateCosineTestMethod()
        {
            var CosineOperator = new CosineOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("cos").ToString(), CosineOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateTangentTestMethod()
        {
            var TangentOperator = new TangentOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("tan").ToString(), TangentOperator.ToString());
        }

        [Test]
        public void OperatorFactoryCreateLnTestMethod()
        {
            var LnOperator = new LnOperator();
            Assert.AreEqual(OperatorFactory.GetOperator("ln").ToString(), LnOperator.ToString());
        }
 
    }
}

