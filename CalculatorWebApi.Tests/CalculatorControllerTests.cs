using CalculatorWebApi.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework.Internal;
using System.Text.Json.Nodes;

namespace CalculatorWebApi.Tests
{
    public class CalculatorControllerTests
    {
        [Test]
        public void AddReturnsCorrectNumber()
        {
            var expectedResponse = "{\"result\":15}";

            var logger = Mock.Of<ILogger<CalculatorController>>();
            var controller = new CalculatorController(logger);

            var actualResponse = controller.Add(5, 10);

            Assert.That(actualResponse, Is.EqualTo(expectedResponse));
        }
    }
}