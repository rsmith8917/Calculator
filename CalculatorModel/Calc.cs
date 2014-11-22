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

        public string ParseInfixExpression(string input)
        {
            return "";
        }

        public double EvaluateReversePolish(string expression)
        {
            double result = 0;

            Stack<double> valueStack = new Stack<double>();

            string[] expressionArray = expression.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in expressionArray)
            {
                try
                {
                    valueStack.Push(this.GetNumber(token));
                }
                catch
                {
                    Operator op = OperatorFactory.GetOperator(token);
                    try
                    {
                        valueStack.Push(op.Operate(valueStack));
                    }
                    catch (InvalidOperationException e)
                    { 
                        throw new Exception("Improperly formatted expression.", e); 
                    }
                }
            }

            try 
            {
                result = valueStack.Pop();
                if (valueStack.Count > 0)
                    throw new Exception("Improperly formatted expression.");
            }
            catch (InvalidOperationException e)
            {
                throw new Exception("Improperly formatted expression.", e);
            }

            return result;
        }

        private double GetNumber(string token)
        {
            token = token.ToLower();

            switch (token)
            {
                case "pi":
                    return Math.PI;
                case "e":
                    return Math.E;
                default:
                    return Convert.ToDouble(token);
            }
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
