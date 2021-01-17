using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class CalcProcessor
    {
        public double Calculate(string argOperator, double argFirstNumb, double argSecondNumb)
        {
            double result;
            switch (argOperator.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumb + argSecondNumb;
                    break;
                case "substract":
                case "-":
                case "minus":
                    result = argFirstNumb - argSecondNumb;
                    break;
                case "times":
                case "x":
                case "multiply":
                case "*":
                    result = argFirstNumb * argSecondNumb;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumb / argSecondNumb;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }
            return result;
        }
    }
}
