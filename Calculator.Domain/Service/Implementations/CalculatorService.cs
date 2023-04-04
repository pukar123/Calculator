
using Calculator.Domain.DTO;

namespace Calculator.Domain.Service.Implementations
{
    public class CalculatorService:ICalculatorService
    {
        public decimal Add(CalculatorDTO calc)
        {
            return calc.FirstInput + calc.SecondInput;
        }

        public decimal Subtract(CalculatorDTO calc)
        {
            return calc.FirstInput - calc.SecondInput;
        }

        public decimal Multiply(CalculatorDTO calc)
        {
            return calc.FirstInput * calc.SecondInput;
        }

        public decimal Divide(CalculatorDTO calc)
        {
            if (calc.SecondInput == 0)
            {
                throw new ArgumentException("Invalid Input, Cannot divide by zero");
            }
            return calc.FirstInput / calc.SecondInput;
        }
    }
}
