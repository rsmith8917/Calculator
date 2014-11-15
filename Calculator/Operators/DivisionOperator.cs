using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class DivisionOperator : Operator
    {
        public override double Operate(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            else
                return num1 / num2;
        }
    }
}
