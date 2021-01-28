using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalProceesorTest
    {
        private readonly CalcProcessor _calcProcessor = new CalcProcessor();
        [TestMethod]
        public void AddToCheck() 
        {
            int numb1 = 2;
            int numb2 = 3;
            double result = _calcProcessor.Calculate("add", numb1, numb2);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void OperationToCheck()
        {
            int numb1 = 2;
            int numb2 = 3;
            double result = _calcProcessor.Calculate("+", numb1, numb2);
            Assert.AreEqual(5, result);
        }
    }
}
