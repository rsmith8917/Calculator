using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class SquareRootOperator : Operator
    {
        public override double Operate(Stack<double> numStack)
        {
            double num = numStack.Pop();
            return Math.Sqrt(num);
        }
    }
}
