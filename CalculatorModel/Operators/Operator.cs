using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operator
    {
        protected int precedance;

        public int Precedance
        {
            get { return this.precedance; }
        }

        public virtual double Operate(Stack<double> numStack)
        {
            return 0;
        }
    }
}
