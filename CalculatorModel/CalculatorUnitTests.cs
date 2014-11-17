using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class AdditionOperatorUnitTests
    {
        [TestMethod]
        public void ReversePolishThreeFourPlusEqualsSevenTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("3 4 +");
            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        public void ReversePolishThreeFourMinusEqualsNegativeOneTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("3 4 -");
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void ReversePolishThreeFourTimesEqualsTwelveTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("3 4 *");
            Assert.AreEqual(result, 12);
        }

        [TestMethod]
        public void ReversePolishThreeFourDivideEqualsThreeFourthsTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("3 4 /");
            Assert.AreEqual(result, 0.75);
        }

        [TestMethod]
        public void ReversePolishPISquaredEqualsNinePointEightSevenTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("PI 2 ^");
            Assert.AreEqual(result, 9.86960440108935, 1e-8);
        }

        [TestMethod]
        public void ReversePolishESquaredEqualsSevenPointThreeNineTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("e 2 ^");
            Assert.AreEqual(result, 7.38905609893, 1e-8);
        }

        [TestMethod]
        public void ReversePolishOneFortyFourSquareRootEqualsTwelveTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("144 sqrt");
            Assert.AreEqual(result, 12);
        }

        [TestMethod]
        public void ReversePolishNineSquareRootEqualsThreeTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("9 SQRT");
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void ReversePolishMultipleOperationsTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("5 1 2 + 4 * + 3 -");
            Assert.AreEqual(result, 14);
        }

        [TestMethod]
        public void ReversePolishFractionalOperationsTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("5.2 1 2.3 + 4 * + 3.7 -");
            Assert.AreEqual(result, 14.7);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ReversePolishBadTokenThrowsExceptionTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("q 5 2 A");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ReversePolishEmptyExpressionThrowsExceptionTestMethod()
        {
            var calculator = new Calc();
            var result = calculator.EvaluateReversePolish("");
        }
    }
}

