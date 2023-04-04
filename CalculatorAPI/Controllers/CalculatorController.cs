using Calculator.Domain.DTO;
using Calculator.Domain.Service;
using CalculatorAPI.Extension;
using Microsoft.AspNetCore.Mvc;


namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public ActionResult<decimal> Add([FromQuery] CalculatorDTO calc)
        {
            return _calculatorService.Add(calc);
        }

        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract([FromQuery] CalculatorDTO calc)
        {
            return _calculatorService.Subtract(calc);
        }

        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply([FromQuery] CalculatorDTO calc)
        {
            return _calculatorService.Multiply(calc);
        }

        [HttpGet("divide")]
        public ActionResult<decimal> Divide([FromQuery] CalculatorDTO calc)
        {
            return _calculatorService.Divide(calc);
        }
    }
}
