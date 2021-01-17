using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class InputConversion
    {
        public double ConvertInputToNumb (string argTextInput)
        {
            double convertedNumb;
            if (!double.TryParse(argTextInput, out convertedNumb)) throw new ArgumentException("Expected a Numerical value");
            return convertedNumb;
        }
    }
}
