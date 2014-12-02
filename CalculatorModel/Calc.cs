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
        Stack<string> operatorStack = new Stack<string>();

        public void Calculate()
        {
            this.expression = Convert.ToString(
                                EvaluateReversePolish(
                                    ParseInfixExpression(expression)));
        }

        public string ParseInfixExpression(string input)
        {
            operatorStack = new Stack<string>();
            StringBuilder output = new StringBuilder("");

            string[] inputArray = SplitInput(input);

            foreach ( string token in inputArray )
            {
                if (ProcessNumericToken(output, token)) { }
                else { ProcessOperatorToken(output, token); }
            }

            BuildOutputString(output);

            return output.ToString();
        }

        public double EvaluateReversePolish(string expression)
        {
            valueStack = new Stack<double>();

            string[] expressionArray = SplitInput(expression);

            foreach (string token in expressionArray)
            {
                if( EvaluateNumericToken(token) ) {}
                else{ EvaluateOperatorToken(token); }
            }

            return GetResult();
        }


        #region Private Methods

        private void BuildOutputString(StringBuilder output)
        {
            int count = operatorStack.Count;

            for (int i = 0; i < count; i++)
            {
                output.Append(operatorStack.Pop());
                if (i < count - 1)
                    output.Append(" ");
            }
        }

        private void ProcessOperatorToken(StringBuilder output, string token)
        {
            switch (token)
            {
                case "(":
                    operatorStack.Push(token);
                    break;
                case ")":
                    while (operatorStack.Peek() != "(")
                    {
                        AddOperatorToOutputExpression(output);
                    }
                    operatorStack.Pop();
                    break;
                default:
                    if (operatorStack.Count > 0)
                    {
                        if (OperatorIsLowerOrEqualPrecedanceThanLast(token))
                        {
                            AddOperatorToOutputExpression(output);
                        }
                    }
                    operatorStack.Push(token);
                    break;

            }
        }

        private bool ProcessNumericToken(StringBuilder output, string token)
        {
            bool status = true;

            try
            {
                output.Append(this.GetNumber(token).ToString());
                output.Append(" ");
            }
            catch (Exception)
            {
                status = false;
            }

            return status;
        }

        private void AddOperatorToOutputExpression(StringBuilder output)
        {
            output.Append(operatorStack.Pop());
            output.Append(" ");
        }

        private bool OperatorIsLowerOrEqualPrecedanceThanLast(string token)
        {
            int tokenPrecedance = OperatorFactory.GetOperator(token).Precedance;
            int lastPrecendance = OperatorFactory.GetOperator(operatorStack.Peek()).Precedance;

            return tokenPrecedance <= lastPrecendance;
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

        private void EvaluateOperatorToken(string token)
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

        private bool EvaluateNumericToken(string token)
        {
            bool status = true;

            try
            {
                valueStack.Push(this.GetNumber(token));
            }
            catch (Exception)
            {
                status = false;
            }

            return status;
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

        #endregion

        #region NotifyPropertyChanged Methods

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
