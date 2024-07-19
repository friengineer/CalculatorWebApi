using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("add")]
        public IActionResult Add(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            var resultObject = new { Result = result };
            
            return Ok(resultObject);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(int firstNumber, int secondNumber)
        {
            var result = firstNumber - secondNumber;
            var resultObject = new { Result = result };

            return Ok(resultObject);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(int firstNumber, int secondNumber)
        {
            var result = firstNumber * secondNumber;
            var resultObject = new { Result = result };

            return Ok(resultObject);
        }
    }
}
