using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class LnOperator : Operator
    {
        public LnOperator()
        {
            this.precedance = 3;
        }

        public override double Operate(Stack<double> numStack)
        {
            return Math.Log(numStack.Pop());
        }
    }
}
