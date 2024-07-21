using CalculatorWebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Text.Json.Nodes;

namespace CalculatorWebApi.Tests
{
    public class CalculatorControllerTests
    {
        private static readonly JsonObject _requestPayload = new() { ["firstNumber"] = 10, ["secondNumber"] = 5 };
        private ILogger<CalculatorController> _logger;
        private CalculatorController _controller;

        [SetUp]
        public void Setup()
        {
            _logger = Mock.Of<ILogger<CalculatorController>>();
            _controller = new CalculatorController(_logger);
        }

        [Test]
        public void AddReturnsCorrectResponse()
        {
            // Arrange
            var expectedResponse = new OkObjectResult(new { Result = 15 });

            // Act
            var response = _controller.Add(_requestPayload);
            var okResponse = (OkObjectResult)response;

            // Assert
            Assert.That(response, Is.TypeOf<OkObjectResult>());
            Assert.That(okResponse.Value!.ToString(), Is.EqualTo(expectedResponse.Value!.ToString()));
        }

        [Test]
        public void SubtractReturnsCorrectResponse()
        {
            // Arrange
            var expectedResponse = new OkObjectResult(new { Result = 5 });

            // Act
            var response = _controller.Subtract(_requestPayload);
            var okResponse = (OkObjectResult)response;

            // Assert
            Assert.That(response, Is.TypeOf<OkObjectResult>());
            Assert.That(okResponse.Value!.ToString(), Is.EqualTo(expectedResponse.Value!.ToString()));
        }

        [Test]
        public void MultiplyReturnsCorrectResponse()
        {
            // Arrange
            var expectedResponse = new OkObjectResult(new { Result = 50 });

            // Act
            var response = _controller.Multiply(_requestPayload);
            var okResponse = (OkObjectResult)response;

            // Assert
            Assert.That(response, Is.TypeOf<OkObjectResult>());
            Assert.That(okResponse.Value!.ToString(), Is.EqualTo(expectedResponse.Value!.ToString()));
        }

        [Test]
        public void DivideReturnsCorrectResponse()
        {
            // Arrange
            var expectedResponse = new OkObjectResult(new { Result = 2 });

            // Act
            var response = _controller.Divide(_requestPayload);
            var okResponse = (OkObjectResult)response;

            // Assert
            Assert.That(response, Is.TypeOf<OkObjectResult>());
            Assert.That(okResponse.Value!.ToString(), Is.EqualTo(expectedResponse.Value!.ToString()));
        }
    }
}
