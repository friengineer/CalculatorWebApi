using CalculatorWebApi.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework.Internal;

namespace CalculatorWebApi.Tests
{
    public class CalculatorControllerTests
    {
        [Test]
        public void AddReturnsCorrectNumber()
        {
            var logger = Mock.Of<ILogger<CalculatorController>>();
            var controller = new CalculatorController(logger);
            var response = controller.Add(5, 10);

            Assert.That(response, Is.EqualTo(15));
        }
    }
}