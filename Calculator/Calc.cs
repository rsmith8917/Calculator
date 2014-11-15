using Calculator.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc : INotifyPropertyChanged
    {
        private Stack<double> valueStack = new Stack<double>();

        private double result = 0;

        private string exp;

        public string expression 
        { 
            get { return exp; }
            set { exp = value; NotifyPropertyChanged(); } 
        }

        public void Calculate()
        {
            this.expression = Convert.ToString(EvaluateReversePolish(expression));
        }

        public double EvaluateReversePolish(string expression)
        {
            string[] expressionArray = expression.Split(' ');
            foreach (string token in expressionArray)
            {
                try
                {
                    valueStack.Push(Convert.ToDouble(token));
                }
                catch
                {
                    Operator op = OperatorFactory.GetOperator(token);
                    valueStack.Push(op.Operate(valueStack));
                }
            }

            try 
            {
                result = valueStack.Pop();
            }
            catch (InvalidOperationException e)
            {
                throw new Exception("Improperly formatted expression.", e);
            }

            return result;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
