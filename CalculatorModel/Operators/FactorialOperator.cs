using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class FactorialOperator : Operator
    {
        public override double Operate(Stack<double> numStack)
        {
            long num = Convert.ToInt64(numStack.Pop());

            double result = 1;

            while (num > 1)
            {
                result *= num;
                num--;
            }

            return result;

        }
    }
}
