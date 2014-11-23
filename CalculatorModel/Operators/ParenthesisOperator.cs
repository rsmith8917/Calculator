using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class ParenthesisOperator : Operator
    {
        public ParenthesisOperator()
        {
            this.precedance = -1;
        }

        public override double Operate(Stack<double> numStack)
        {
            return 0;
        }
    }
}
