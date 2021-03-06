﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class CosineOperator : Operator
    {
        public CosineOperator()
        {
            this.precedance = 3;
        }

        public override double Operate(Stack<double> numStack)
        {
            double num = numStack.Pop();
            return Math.Round(Math.Cos(num),12);
        }
    }
}
