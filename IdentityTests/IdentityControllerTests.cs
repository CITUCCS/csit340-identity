using Identity;
using Identity.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace IdentityTests
{
    public class IdentityControllerTests
    {
        private IdentityController _controller;
        private Mock<IAgifyClient> _mockAgifyClient;

        public IdentityControllerTests()
        {
            _mockAgifyClient = new Mock<IAgifyClient>();
            _controller = new IdentityController(_mockAgifyClient.Object);
        }

        [Fact]
        public async Task GetIdentity_ValidName_ReturnCorrectAge()
        {
            // Arrange
            var testName = "Jhon";
            var expectedAge = 51;

            _mockAgifyClient.Setup(c => c.GetAge(It.IsAny<string>()))
                .ReturnsAsync(new AgeResponse { Age = 51 });

            // Act
            var response = await _controller.GetIdentity(testName);

            // Assert
            Assert.IsType<OkObjectResult>(response);
            var okObject = response as OkObjectResult;

            Assert.IsType<AgeResponse>(okObject!.Value);
            var ageResponse = okObject!.Value as AgeResponse;

            Assert.Equal(expectedAge, ageResponse!.Age);

        }
    }
}