using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class AdditionOperator : Operator
    {
        public override double Operate(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
