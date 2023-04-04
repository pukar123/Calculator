using Calculator.Domain.DTO;

namespace Calculator.Domain.Service
{
    public interface ICalculatorService
    {
        decimal Add(CalculatorDTO calc);
        decimal Subtract(CalculatorDTO calc);
        decimal Multiply(CalculatorDTO calc);
        decimal Divide(CalculatorDTO calc);
    }
}
