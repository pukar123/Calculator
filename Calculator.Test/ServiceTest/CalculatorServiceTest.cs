using Calculator.Domain.DTO;
using Calculator.Domain.Service.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test.ServiceTest
{
    [TestClass]
    public class CalculatorServiceTest
    {
        public CalculatorServiceTest() { }
        [TestMethod]
        public void AdditionTest()
        {
            CalculatorDTO calc=new CalculatorDTO();
            CalculatorService calcService = new CalculatorService();
            calc.FirstInput = 1;
            calc.SecondInput = 2;
            var actual = calcService.Add(calc);
            Assert.AreEqual(3, actual);
        }
        [TestMethod]
        public void SubtractionTest()
        {
            CalculatorDTO calc = new CalculatorDTO();
            CalculatorService calcService = new CalculatorService();
            calc.FirstInput = 9;
            calc.SecondInput = 2;
            var actual = calcService.Subtract(calc);
            Assert.AreEqual(7, actual);
        }
        [TestMethod]
        public void MultiplicationTest()
        {
            CalculatorDTO calc = new CalculatorDTO();
            CalculatorService calcService = new CalculatorService();
            calc.FirstInput = 4;
            calc.SecondInput = 2;
            var actual = calcService.Multiply(calc);
            Assert.AreEqual(8, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Invalid Input, Cannot divide by zero")]
        public void DivisionExceptionTest()
        {
            CalculatorDTO calc = new CalculatorDTO();
            CalculatorService calcService = new CalculatorService();
            calc.FirstInput = 8;
            calc.SecondInput = 0;
            calcService.Divide(calc);
        }
        [TestMethod]
       
        public void DivisionTest()
        {
            CalculatorDTO calc = new CalculatorDTO();
            CalculatorService calcService = new CalculatorService();
            calc.FirstInput = 8;
            calc.SecondInput = 2;
            var actual=calcService.Divide(calc);
            Assert.AreEqual(4, actual);
        }

    }
}
