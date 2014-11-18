﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class SineOperator : Operator
    {
        public override double Operate(Stack<double> numStack)
        {
            double num = numStack.Pop();
            return Math.Sin(num);
        }
    }
}
