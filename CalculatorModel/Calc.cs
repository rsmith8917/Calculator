using Calculator.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        Stack<double> valueStack = new Stack<double>();

        public void Calculate()
        {
            this.expression = Convert.ToString(
                                EvaluateReversePolish(
                                    ParseInfixExpression(expression)));
        }

        public string ParseInfixExpression(string input)
        {
            Stack<string> operatorStack = new Stack<string>();
            string[] inputArray = SplitInput(input);
            StringBuilder output = new StringBuilder("");

            foreach ( string token in inputArray )
            {
                try
                {
                    output.Append(this.GetNumber(token).ToString());
                    output.Append(" ");
                }
                catch
                {
                    switch ( token ){
                        case "(":
                            operatorStack.Push(token);
                            break;
                        case ")":
                            while (operatorStack.Peek() != "(")
                            {
                                output.Append(operatorStack.Pop());
                                output.Append(" ");
                            }
                            operatorStack.Pop();
                            break;
                        default:
                            if ( operatorStack.Count > 0 )
                            {
                                if (OperatorFactory.GetOperator(token).Precedance <= OperatorFactory.GetOperator(operatorStack.Peek()).Precedance)
                                {
                                    output.Append(operatorStack.Pop());
                                    output.Append(" ");
                                }
                            }
                            operatorStack.Push(token);
                            break;
                        
                    }
                    
                    
                    
                }
            }

            int count = operatorStack.Count;

            for (int i = 0; i < count; i++)
            {
                output.Append( operatorStack.Pop() );
                if (i < count - 1)
                    output.Append(" ");
            }

            return output.ToString();
        }

        public double EvaluateReversePolish(string expression)
        {
            valueStack = new Stack<double>();

            string[] expressionArray = SplitInput(expression);

            foreach (string token in expressionArray)
            {
                ProcessToken(token);
            }

            return GetResult();
        }

        private double GetResult()
        {
            double result = 0;

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

        private void ProcessToken(string token)
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

        private string[] SplitInput(string input)
        {
            input = input.ToLower();

            string[] inputArray = input.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            foreach (string str in inputArray)
            {
                result.AddRange(Regex.Split(str, OperatorFactory.RegexPattern));
            }

            return result.Where(x => !string.IsNullOrEmpty(x)).ToArray();
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
