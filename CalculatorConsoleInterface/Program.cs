using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calculator = new Calc();
            Console.WriteLine(calculator.EvaluateReversePolish("3 SQRT").ToString());
            Console.ReadLine();
        }
    }
}
