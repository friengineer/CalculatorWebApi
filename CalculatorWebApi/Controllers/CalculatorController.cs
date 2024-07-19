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
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
