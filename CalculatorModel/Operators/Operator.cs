using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operator
    {
        public virtual double Operate(Stack<double> numStack)
        {
            return 0;
        }
    }
}
