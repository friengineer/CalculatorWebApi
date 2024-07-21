using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace CalculatorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Add(JsonObject requestJson)
        {
            var firstNumber = requestJson["firstNumber"]!.GetValue<int>();
            var secondNumber = requestJson["secondNumber"]!.GetValue<int>();
            var result = firstNumber + secondNumber;
            var resultObject = new { Result = result };

            return Ok(resultObject);
        }

        [HttpPost]
        public IActionResult Subtract(JsonObject requestJson)
        {
            var firstNumber = requestJson["firstNumber"]!.GetValue<int>();
            var secondNumber = requestJson["secondNumber"]!.GetValue<int>();
            var result = firstNumber - secondNumber;
            var resultObject = new { Result = result };

            return Ok(resultObject);
        }

        [HttpPost]
        public IActionResult Multiply(JsonObject requestJson)
        {
            var firstNumber = requestJson["firstNumber"]!.GetValue<int>();
            var secondNumber = requestJson["secondNumber"]!.GetValue<int>();
            var result = firstNumber * secondNumber;
            var resultObject = new { Result = result };

            return Ok(resultObject);
        }

        [HttpPost]
        public IActionResult Divide(JsonObject requestJson)
        {
            var firstNumber = requestJson["firstNumber"]!.GetValue<int>();
            var secondNumber = requestJson["secondNumber"]!.GetValue<int>();
            var result = firstNumber / secondNumber;
            var resultObject = new { Result = result };

            return Ok(resultObject);
        }
    }
}
