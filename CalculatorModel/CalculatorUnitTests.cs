using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Calculator
{
    [TestFixture]
    public class AdditionOperatorUnitTests
    {
        private Calc calculator;

        [SetUp]
        public void TestInitialize()
        {
            calculator = new Calc();
        }

        #region Reverse Polish Tests
        [Test]
        public void ReversePolishThreeFourPlusEqualsSevenTest()
        {
            var result = calculator.EvaluateReversePolish("3 4 +");
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void ReversePolishThreeFourMinusEqualsNegativeOneTest()
        {
            var result = calculator.EvaluateReversePolish("3 4 -");
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void ReversePolishThreeFourTimesEqualsTwelveTest()
        {
            var result = calculator.EvaluateReversePolish("3 4 *");
            Assert.AreEqual(result, 12);
        }

        [Test]
        public void ReversePolishThreeFourDivideEqualsThreeFourthsTest()
        {
            var result = calculator.EvaluateReversePolish("3 4 /");
            Assert.AreEqual(result, 0.75);
        }

        [Test]
        public void ReversePolishPISquaredEqualsNinePointEightSevenTest()
        {
            var result = calculator.EvaluateReversePolish("PI 2 ^");
            Assert.AreEqual(result, 9.86960440108935, 1e-8);
        }

        [Test]
        public void ReversePolishESquaredEqualsSevenPointThreeNineTest()
        {
            var result = calculator.EvaluateReversePolish("e 2 ^");
            Assert.AreEqual(result, 7.38905609893, 1e-8);
        }

        [Test]
        public void ReversePolishOneFortyFourSquareRootEqualsTwelveTest()
        {
            var result = calculator.EvaluateReversePolish("144 sqrt");
            Assert.AreEqual(result, 12);
        }

        [Test]
        public void ReversePolishNineSquareRootEqualsThreeTest()
        {
            var result = calculator.EvaluateReversePolish("9 SQRT");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void ReversePolishMultipleOperationsTest()
        {
            var result = calculator.EvaluateReversePolish("5 1  2 +  4 *   + 3 -");
            Assert.AreEqual(result, 14);
        }

        [Test]
        public void CalculateMultipleOperationsTest()
        {
            calculator.expression = "5 1 2 + 4 * + 3 -";
            calculator.Calculate();
            Assert.AreEqual(calculator.expression, "14");
        }

        [Test]
        public void ReversePolishFractionalOperationsTest()
        {
            var result = calculator.EvaluateReversePolish("5.2 1 2.3 + 4 * + 3.7 -");
            Assert.AreEqual(result, 14.7);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void ReversePolishBadTokenThrowsExceptionTest()
        {
            var result = calculator.EvaluateReversePolish("q 5 2 A");
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void ReversePolishEmptyExpressionThrowsExceptionTest()
        {
            var result = calculator.EvaluateReversePolish("");
        }
        #endregion

        #region Infix Conversion Tests

        [Test]
        public void InfixSimpleTest()
        {
            var result = calculator.ParseInfixExpression("3 + 4");
            Assert.AreEqual(result, "3 4 +");
        }

        #endregion
    }
}

