﻿using System;
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

            Console.WriteLine("Reverse Polish Calculator");
            Console.WriteLine();

            while ( true )
            {
                Console.Write(">> ");
                calculator.expression = Console.ReadLine();
                if (calculator.expression == "exit")
                    break;
                try { 
                    calculator.Calculate();
                    Console.WriteLine();
                    Console.Write("Ans = ");
                    Console.WriteLine(calculator.expression);
                    Console.WriteLine();
                }
                catch (Exception e) { 
                    Console.WriteLine();
                    Console.WriteLine("ERROR: " + e.Message);
                    Console.WriteLine();
                }
                

            }
        }
    }
}