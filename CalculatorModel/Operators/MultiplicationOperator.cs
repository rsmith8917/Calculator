﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class MultiplicationOperator : Operator
    {
        public MultiplicationOperator()
        {
            this.precedance = 1;
        }
        public override double Operate(Stack<double> numStack)
        {
            double num2 = numStack.Pop();
            double num1 = numStack.Pop();
            return num1 * num2;
        }
    }
}
