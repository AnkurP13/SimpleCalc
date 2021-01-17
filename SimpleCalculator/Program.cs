using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConversion inputConversion = new InputConversion();
                CalcProcessor calcProcessor = new CalcProcessor();

                double FirstNumb = inputConversion.ConvertInputToNumb(Console.ReadLine());
                double SecondNumb = inputConversion.ConvertInputToNumb(Console.ReadLine());
                string Operator = Console.ReadLine();

                double Res = calcProcessor.Calculate(Operator, FirstNumb, SecondNumb);
                Console.WriteLine(Res);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
             



        }
    }
}
