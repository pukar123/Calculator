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
        //Takes two values as input and shows their sum as output

        [HttpGet("add")]
        public ActionResult<decimal> Add([FromQuery] CalculatorDTO calc)
        {
            try
            {
                return Ok(_calculatorService.Add(calc));
            }
            catch (Exception ex)
            {

                return BadRequest(new ProblemDetails
                {
                    Title = "Something went wrong",
                    Detail = $"{ex.Message}"
                });
            }
        }
        //Takes two values as input and shows their difference as output
        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract([FromQuery] CalculatorDTO calc)
        {
            try
            {
                return Ok(_calculatorService.Subtract(calc));
            }
            catch (Exception ex)
            {

                return BadRequest(new ProblemDetails
                {
                    Title = "Something went wrong",
                    Detail = $"{ex.Message}"
                });
            }
        }
        //Takes two values as input and shows their Multiplication as output
        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply([FromQuery] CalculatorDTO calc)
        {
            try
            {
                return Ok(_calculatorService.Multiply(calc));
            }
            catch (Exception ex)
            {

                return BadRequest(new ProblemDetails
                {
                    Title = "Something went wrong",
                    Detail = $"{ex.Message}"
                });
            }
        }
        //Takes two values as input and shows result as first value divided by second value
        [HttpGet("divide")]
        public ActionResult<decimal> Divide([FromQuery] CalculatorDTO calc)
        {
            try
            {
                return Ok(_calculatorService.Divide(calc));
            }
            catch (Exception ex)
            { 
                return BadRequest(new ProblemDetails { 
                    Title = "Something went wrong", 
                    Detail = $"{ex.Message}" }); 
            }
        }
    }
}
