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
        
        [Test]
        [TestCase("3 4 +", Result = 7)]
        [TestCase("3 4 -", Result = -1)]
        [TestCase("3 4 *", Result = 12)]
        [TestCase("3 4 /", Result = 0.75)]
        [TestCase("144 sqrt", Result = 12)]
        [TestCase("9 SQRT", Result = 3)]
        [TestCase("5 1  2 +  4 *   + 3 -", Result = 14)]
        [TestCase("5.2 1 2.3 + 4 * + 3.7 -", Result = 14.7)]
        public double ReversePolishTest(string expression)
        {
            return calculator.EvaluateReversePolish(expression);
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
        public void CalculateMultipleOperationsTest()
        {
            calculator.expression = "1 + 2 * 5 - 3";
            calculator.Calculate();
            Assert.AreEqual(calculator.expression, "8");
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        [TestCase("")]
        [TestCase("q 5 2 A")]
        [TestCase("3 4 =")]
        [TestCase("3 + 4")]
        [TestCase("1 2 3 -")]
        [TestCase("(1 - 3)")]
        public void ReversePolishBadInputThrowsExceptionTest(string expression)
        {
            calculator.EvaluateReversePolish(expression);
        }

        [Test]
        [TestCase("3 + 4" , Result = "3 4 +")]
        [TestCase("3 + 4 - 7", Result = "3 4 + 7 -")]
        [TestCase("3 - 4 + 7", Result = "3 4 - 7 +")]
        [TestCase("3 + 4 * 7", Result = "3 4 7 * +")]
        [TestCase("3 / 4 - 7", Result = "3 4 / 7 -")]
        [TestCase("3 / 4 ^ 7", Result = "3 4 7 ^ /")]
        [TestCase("3 * 4 % 7", Result = "3 4 * 7 %")]
        [TestCase("3 / 4 !", Result = "3 4 ! /")]
        [TestCase("3 / ( 4 - 7 )", Result = "3 4 7 - /")]
        [TestCase("( 1 + 2 ) * ( 4 - 7 )", Result = "1 2 + 4 7 - *")]
        [TestCase("3 + 4 * 2 / ( 1 - 5 ) ^ 2", Result = "3 4 2 * 1 5 - 2 ^ / +")]
        [TestCase("3+4", Result = "3 4 +")]
        [TestCase("3+4*7", Result = "3 4 7 * +")]
        [TestCase("3/4-7", Result = "3 4 / 7 -")]
        [TestCase("(1+2)*(4-7)", Result = "1 2 + 4 7 - *")]
        [TestCase("3+4*2/(1-5)^2", Result = "3 4 2 * 1 5 - 2 ^ / +")]
        [TestCase("3/4!", Result = "3 4 ! /")]
        [TestCase("3*4%7", Result = "3 4 * 7 %")]
        [TestCase("sin(7)", Result = "7 sin")]
        [TestCase("SQRT(7)", Result = "7 sqrt")]
        public string InfixSimpleTest(string input)
        {
            return calculator.ParseInfixExpression(input);
        }

    }
}

