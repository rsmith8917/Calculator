using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class DivisionOperator : Operator
    {
        public DivisionOperator()
        {
            this.precedance = 1;
        }

        public override double Operate(Stack<double> numStack)
        {
            double num2 = numStack.Pop();
            double num1 = numStack.Pop();
            if (num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            else
                return num1 / num2;
        }
    }
}
