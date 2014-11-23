using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    static class OperatorFactory
    {
        static public string RegexPattern
        {
            get { return @"([()!%\^\+\*/-]|sin|sqrt)"; }
        }

        static public Operator GetOperator(string token)
        {

            token = token.ToLower();

            switch (token)
            {
                case "+":
                    return new AdditionOperator();
                case "-":
                    return new SubtractionOperator();
                case "*":
                    return new MultiplicationOperator();
                case "/":
                    return new DivisionOperator();
                case "%":
                    return new ModulusOperator();
                case "sqrt":
                    return new SquareRootOperator();
                case "^":
                    return new PowerOperator();
                case "!":
                    return new FactorialOperator();
                case "sin":
                    return new SineOperator();
                case ")":
                case "(":
                    return new ParenthesisOperator();
                default:
                    throw new Exception("Bad Token");
            }
        }
    }
}
