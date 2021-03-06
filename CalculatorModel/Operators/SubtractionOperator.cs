﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class SubtractionOperator : Operator
    {
        public SubtractionOperator()
        {
            this.precedance = 0;
        }

        public override double Operate(Stack<double> numStack)
        {
            double num2 = numStack.Pop();
            double num1 = numStack.Pop();
            return num1 - num2;
        }
    }
}
