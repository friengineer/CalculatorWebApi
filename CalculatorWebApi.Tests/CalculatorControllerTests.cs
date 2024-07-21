using CalculatorWebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Text.Json.Nodes;

namespace CalculatorWebApi.Tests
{
    public class CalculatorControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddReturnsCorrectResponse()
        {
            // Arrange
            var expectedResponse = new OkObjectResult(new { Result = 15 });
            var requestPayload = new JsonObject { ["firstNumber"] = 10, ["secondNumber"] = 5 };
            var logger = Mock.Of<ILogger<CalculatorController>>();
            var controller = new CalculatorController(logger);

            // Act
            var response = controller.Add(requestPayload);
            var okResponse = (OkObjectResult)response;

            // Assert
            Assert.That(response, Is.TypeOf<OkObjectResult>());
            Assert.That(okResponse.Value!.ToString(), Is.EqualTo(expectedResponse.Value!.ToString()));
        }
    }
}
