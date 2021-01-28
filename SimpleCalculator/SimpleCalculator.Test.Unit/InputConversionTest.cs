using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConversionTest
    {
        private readonly InputConversion _inputConversion = new InputConversion();
        [TestMethod]
        public void ConvertsTheValidInput()
        {
            string inputnumb = "5";
            double convertednumb = _inputConversion.ConvertInputToNumb(inputnumb);
            Assert.AreEqual(5, convertednumb);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailureForConverstionInputToDouble()
        {
            string inputnumb = "+";
            double convertednumb = _inputConversion.ConvertInputToNumb(inputnumb);
           
        }
    }
}
