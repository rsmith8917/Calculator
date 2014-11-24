using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Operators.Tests
{
    [TestFixture]
    public class OperatorUnitTests
    {
        private Stack<double> numStack;

        [SetUp]
        public void TestInitialize()
        {
            numStack = new Stack<double>();
        }

        #region Addition Operator Tests
        [Test]
        [TestCase(1, 2, Result = 3)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(-5, 3, Result = -2)]
        [TestCase(7.5, 1.2, Result = 8.7)]
        public double AdditionOperatorTestMethod(double num1, double num2)
        {
            var AdditionOperator = new AdditionOperator();
            numStack.Push(num1);
            numStack.Push(num2);
            return AdditionOperator.Operate(numStack);
        }

        [Test]
        public void AdditionPrecedanceTestMethod()
        {
            var AdditionOperator = new AdditionOperator();
            Assert.AreEqual(AdditionOperator.Precedance, 0);
        }

        #endregion

        #region Subtraction Operator Tests
        [Test]
        [TestCase(1, 2, Result = -1)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(-5, 3, Result = -8)]
        [TestCase(7.5, 1.2, Result = 6.3)]
        public double SubtractionOperatorTestMethod(double num1, double num2)
        {
            var SubtractionOperator = new SubtractionOperator();
            numStack.Push(num1);
            numStack.Push(num2);
            return SubtractionOperator.Operate(numStack);
        }

        [Test]
        public void SubtractionPrecedanceTestMethod()
        {
            var SubtractionOperator = new SubtractionOperator();
            Assert.AreEqual(SubtractionOperator.Precedance, 0);
        }
        #endregion

        #region Multiplication Operator Tests
        [Test]
        [TestCase(1, 2, Result = 2)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(-5, 3, Result = -15)]
        [TestCase(7.5, 1.2, Result = 9)]
        public double MultiplicationOperatorTestMethod(double num1, double num2)
        {
            var MultiplicationOperator = new MultiplicationOperator();
            numStack.Push(num1);
            numStack.Push(num2);
            return MultiplicationOperator.Operate(numStack);
        }

        [Test]
        public void MultiplicationPrecedanceTestMethod()
        {
            var MultiplicationOperator = new MultiplicationOperator();
            Assert.AreEqual(MultiplicationOperator.Precedance, 1);
        }
        #endregion

        #region Division Operator Tests
        [Test]
        [TestCase(1, 2, Result = 0.5)]
        [TestCase(-9, 3, Result = -3)]
        [TestCase(16, 4, Result = 4)]
        public double DivisionOperatorTestMethod(double num1, double num2)
        {
            var DivisionOperator = new DivisionOperator();
            numStack.Push(num1);
            numStack.Push(num2);
            return DivisionOperator.Operate(numStack);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ZeroDividedByZeroThrowsDivideByZeroExceptionTestMethod()
        {
            var DivisionOperator = new DivisionOperator();
            numStack.Push(0);
            numStack.Push(0);
            var result = DivisionOperator.Operate(numStack);
        }

        [Test]
        public void DivisionPrecedanceTestMethod()
        {
            var DivisionOperator = new DivisionOperator();
            Assert.AreEqual(DivisionOperator.Precedance, 1);
        }
        #endregion  

        #region Modulus Operator Tests
        [Test]
        [TestCase(1, 2, Result = 1)]
        [TestCase(18, 7, Result = 4)]
        public double ModulusOperatorTestMethod(double num1, double num2)
        {
            var ModulusOperator = new ModulusOperator();
            numStack.Push(num1);
            numStack.Push(num2);
            return ModulusOperator.Operate(numStack);
        }

        [Test]
        [TestCase(0, 0)]
        public void ModulusOperatorNaNTestMethod(double num1, double num2)
        {
            var ModulusOperator = new ModulusOperator();
            numStack.Push(num1);
            numStack.Push(num2);
            Assert.AreEqual(ModulusOperator.Operate(numStack), Double.NaN);
        }

        [Test]
        public void ModulusPrecedanceTestMethod()
        {
            var ModulusOperator = new ModulusOperator();
            Assert.AreEqual(ModulusOperator.Precedance, 1);
        }
        #endregion

        #region Power Operator Tests
        [Test]
        [TestCase(1, 2, Result = 1)]
        [TestCase(5, 1, Result = 5)]
        [TestCase(16, 0, Result = 1)]
        [TestCase(5, 8, Result = 390625)]
        public double PowerOperatorTestMethod(double num1, double num2)
        {
            var PowerOperator = new PowerOperator();
            numStack.Push(num1);
            numStack.Push(num2);
            return PowerOperator.Operate(numStack);
        }

        [Test]
        public void PowerPrecedanceTestMethod()
        {
            var PowerOperator = new PowerOperator();
            Assert.AreEqual(PowerOperator.Precedance, 2);
        }
        #endregion

        #region SquareRoot Operator Tests
        [Test]
        [TestCase(1, Result = 1)]
        [TestCase(0, Result = 0)]
        [TestCase(144, Result = 12)]
        [TestCase(16, Result = 4)]
        public double SquareRootOperatorTestMethod(double num)
        {
            var SquareRootOperator = new SquareRootOperator();
            numStack.Push(num);
            return SquareRootOperator.Operate(numStack);
        }

        [Test]
        public void SquareRootPrecedanceTestMethod()
        {
            var SquareRootOperator = new SquareRootOperator();
            Assert.AreEqual(SquareRootOperator.Precedance, 3);
        }
        #endregion

        #region Factorial Operator Tests
        [Test]
        [TestCase(1, Result = 1)]
        [TestCase(0, Result = 1)]
        [TestCase(5, Result = 120)]
        public double FactorialOperatorTestMethod(double num)
        {
            var FactorialOperator = new FactorialOperator();
            numStack.Push(num);
            return FactorialOperator.Operate(numStack);
        }

        [Test]
        public void FactorialPrecedanceTestMethod()
        {
            var FactorialOperator = new FactorialOperator();
            Assert.AreEqual(FactorialOperator.Precedance, 3);
        }

        #endregion

        #region Sine Operator Tests
        [Test]
        [TestCase(0, Result = 0)]
        [TestCase(Math.PI / 2, Result = 1)]
        [TestCase(-Math.PI / 2, Result = -1)]
        [TestCase(Math.PI / 6, Result = 0.5)]
        public double SineOperatorTestMethod(double num)
        {
            var SineOperator = new SineOperator();
            numStack.Push(num);
            return SineOperator.Operate(numStack);
        }

        [Test]
        public void SinePrecedanceTestMethod()
        {
            var SineOperator = new SineOperator();
            Assert.AreEqual(SineOperator.Precedance, 3);
        }
        #endregion

        #region Cosine Operator Tests
        [Test]
        [TestCase(0, Result = 1)]
        [TestCase(Math.PI / 2, Result = 0)]
        [TestCase(-Math.PI / 2, Result = 0)]
        public double CosineOperatorTestMethod(double num)
        {
            var CosineOperator = new CosineOperator();
            numStack.Push(num);
            return CosineOperator.Operate(numStack);
        }

        [Test]
        public void CosinePrecedanceTestMethod()
        {
            var CosineOperator = new CosineOperator();
            Assert.AreEqual(CosineOperator.Precedance, 3);
        }
        #endregion

        #region Tangent Operator Tests
        [Test]
        [TestCase(0, Result = 0)]
        [TestCase(Math.PI / 4, Result = 1)]
        [TestCase(-Math.PI / 4, Result = -1)]
        public double TangentOperatorTestMethod(double num)
        {
            var TangentOperator = new TangentOperator();
            numStack.Push(num);
            return TangentOperator.Operate(numStack);
        }

        [Test]
        public void TangentPrecedanceTestMethod()
        {
            var TangentOperator = new TangentOperator();
            Assert.AreEqual(TangentOperator.Precedance, 3);
        }
        #endregion

        #region Ln Operator Tests
        [Test]
        [TestCase(1, 0)]
        [TestCase(2, 0.69314718056)]
        [TestCase(50, 3.91202300543)]
        public void LnOperatorTestMethod(double num, double result)
        {
            var LnOperator = new LnOperator();
            numStack.Push(num);
            Assert.AreEqual(result,LnOperator.Operate(numStack),1e-8);
        }

        [Test]
        public void LnPrecedanceTestMethod()
        {
            var LnOperator = new LnOperator();
            Assert.AreEqual(LnOperator.Precedance, 3);
        }
        #endregion
    }
}

